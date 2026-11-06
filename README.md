# 🏛️ Konstantinopolis Aşıkları — 2D Hikaye Odaklı Platform ve Bulmaca Oyunu

**Gang7z Game Jam** etkinliği için **72 saatte** **Unity 2021.3.10f1** ile geliştirilmiş; **Richard** ve **Rosa**'nın hikayesini konu alan, 10 farklı bölüm, zeka bulmacası, yakıt/fener mekaniği, düşman yapay zekası ve oyuncunun seçimine göre değişen **iki farklı oyun sonu** içeren **2D Hikaye Odaklı Platform** oyunudur.

---

## 🎭 Temel Özellikler ve Oyun Mekanikleri

### 1. Hikaye, Diyaloglar ve Çoklu Son (`Dialouge.cs`, `MenuSceneManagement.cs`)
- **Daktilo Efektli Diyalog Sistemi (`Dialouge.cs`)**: Bölümler arasında ve önemli hikaye anlarında Richard ve Rosa arasındaki konuşmaları sunan diyalog sistemi.
- **İki Farklı Final Seçimi**: Oyunun finalinde oyuncunun kararına göre açılan iki dramatik son sahnesi:
  - `KendiniFedaEt.unity`: Richard'ın Rosa'yı kurtarmak için kendini feda ettiği son.
  - `RosayıFedaEt.unity`: Rosa'nın feda edildiği alternatif son.

### 2. 10 Bölüm ve Çeşitli Oynanış Dinamikleri
- **Platform Bölümleri (`Level 1` .. `Level 10`)**: Engeller, tuzaklar (`trap.cs`), toplanabilir altınlar (`coinScript.cs`, `scoreTextScript.cs`) ve devriye gezen düşmanlar (`SimpleEnemyBehaviour.cs`).
- **Yakıt ve Işık Mekaniği (`FuelScript.cs`)**: Karanlık bölümlerde zamanla azalan yakıt/ışık kaynağı ve haritadaki yakıt bidonlarını toplayarak hayatta kalma.
- **Zeka Bulmacası (`Manager.cs`, `BrainGame.unity`)**: Hikaye akışı içinde çözülmesi gereken etkileşimli bulmaca ve zamanlayıcı (`Timer.cs`) bölümleri.

---

## 📂 Proje Klasör Yapısı

```text
Unity-KonstantinopolisAsiklari/
├── Assets/
│   ├── Animations/             # Karakter ve çevre animasyonları
│   ├── Prefabs/                # Altın, düşman, tuzak ve bulmaca prefabları
│   ├── Scenes/                 # Menu, Level 1..10, BrainGame, KendiniFedaEt, RosayıFedaEt
│   ├── Scripts/
│   │   ├── CharacterController.cs
│   │   ├── Dialouge.cs
│   │   ├── FuelScript.cs
│   │   ├── Manager.cs
│   │   ├── MenuSceneManagement.cs
│   │   ├── SimpleEnemyBehaviour.cs
│   │   ├── Timer.cs
│   │   ├── coinScript.cs
│   │   ├── scoreTextScript.cs
│   │   └── trap.cs
│   └── Sprites/                # 2D piksel sanat karakter ve ortam görselleri
├── Packages/
└── ProjectSettings/            # Unity 2021.3.10f1 proje ayarları
```

---

## 🚀 Kurulum ve Çalıştırma

1. Depoyu klonlayın:
   ```bash
   git clone https://github.com/yusufbrny/Unity-KonstantinopolisAsiklari.git
   ```
2. **Unity Hub** üzerinden **Unity 2021.3.10f1** ile projeyi açın.
3. `Assets/Scenes/Menu.unity` sahnesini açarak oyunu başlatın.
