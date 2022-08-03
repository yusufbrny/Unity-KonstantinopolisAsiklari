using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterController : MonoBehaviour
{
	private Collider2D colli;
	public bool _active = true;

	public int speed;
	public int jumpSpeed;
	public string damageVuran;
	public AudioSource ses;

	public Door_script Door;

	public Transform DeadBody;

	public Transform SpawnPoint;
	public int deathTriggerCount = 1;


	int pressCount = 0;

	float moveInput;

	Animator animator;
	Rigidbody2D rb;

	bool canJump = true;
	private bool faceRight = true;

	private void Start()
	{
		ses = GetComponent<AudioSource>();
		animator = GetComponent<Animator>();
		rb = GetComponent<Rigidbody2D>();
		colli = GetComponent<Collider2D>();
		Time.timeScale = 1;
		canJump = true;
	}

	private void Update()
    {

    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.transform.tag == "Platform")
		{
			canJump = true;

			rb.velocity = Vector3.zero;
			rb.angularVelocity = 0f;
			animator.SetBool("isJumping", false);
		}
	}

	public void killMe()
	{
		transform.position = SpawnPoint.position;
	}

	private void FixedUpdate()
	{
		moveInput = Input.GetAxis("Horizontal");


		deathTriggerCount = 1;

		rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

		if(moveInput > 0 || moveInput < 0)
		{
			animator.SetBool("isRunning", true);
		}
		else
		{
			animator.SetBool("isRunning", false);
		}

		if (faceRight == true && moveInput < 0)
		{

			Flip();
		}else if(faceRight == false && moveInput > 0)
		{
			Flip();
		}
		if (Input.GetKey(KeyCode.Space))
		{
			Jump();
			canJump = false;
			animator.SetBool("isJumping", true);
		}

		if (!_active)
        {
			return;
        }

	}

	public  void MoveRight()
	{
		moveInput = 1;
	}

	public  void MoveLeft()
	{
		moveInput = -1;
	}

	public void StopMove()
	{
		moveInput = 0;
	}

	public void Die()
    {
		_active = false;
		colli.enabled = false;
    }

	public void Jump()
	{
		if (canJump)
		{
			rb.AddForce(Vector2.up * jumpSpeed);
			canJump = false;
		}
	}

	private void Flip()
	{
		faceRight = !faceRight;
		Vector3 scaler = transform.localScale;
		scaler.x *= -1;
		transform.localScale = scaler;
	}

	public void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == damageVuran)
		{
			--deathTriggerCount; 
			if (deathTriggerCount == 0)
			{
				DeadBody.position = transform.position;
				DeadBody.GetComponent<Rigidbody2D>().velocity = rb.velocity;

				transform.position = SpawnPoint.position;
				rb.velocity = Vector3.zero;

			}
		}


		

		switch (col.name)
		{
			case "TriggerSuccess":
				PlayerPrefs.SetInt("PlayerLevel", PlayerPrefs.GetInt("PlayerLevel") + 1);
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
				break;

			case "Button":
				switch (SceneManager.GetActiveScene().buildIndex - 1)
				{
					case 1:
						// 1. Plain and simple
						Door.OpenDoor();
						break;
					case 2:
						// 2. Try more
						++pressCount;
						if (pressCount > 0)
						{
							Door.OpenDoor();
						}
						break;
					case 6:
						// 6. Press harder
						if (rb.velocity.y <= -10)
						{
							Door.OpenDoor();
						}
						break;
				}
				break;

			case "PauseButton":
				if (SceneManager.GetActiveScene().buildIndex == 8)
					// 7. Press pauses
					Door.OpenDoor();
				break;

			case "Block":
				if (SceneManager.GetActiveScene().buildIndex == 12)
				{
					// 11. Something heavy
					col.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
					col.GetComponent<Collider2D>().isTrigger = false;
					Door.OpenDoor();
				}
				break;
			case "Platforms_7":
				if (SceneManager.GetActiveScene().buildIndex == 13)
				{
					//12; Sometimes you are Mario
					col.GetComponent<SpriteRenderer>().enabled = false;
					col.GetComponent<Collider2D>().enabled = false;
				}
				break;
		}
	}

}
 