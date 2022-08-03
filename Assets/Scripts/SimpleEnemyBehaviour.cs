using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemyBehaviour : MonoBehaviour
{
    public int speed;
    public int turnDelay;
    public int health;
    Rigidbody2D rb;

    Animator animator;
    Vector3 Vector3;
    Vector2 Vector2;
    GameObject GameObject;
    BoxCollider2D Collider2D;


    bool faceRight = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(SwitchDirections());
    }

    private void Update()
    {
        animator.SetBool("Move", true);
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    IEnumerator SwitchDirections()
    {
        yield return new WaitForSeconds(turnDelay);
        Switch();

    }

    private void Switch()
    {
        faceRight = !faceRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;

        speed *= -1;
        StartCoroutine(SwitchDirections());
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
            Destroy(gameObject);
    }

   
}

