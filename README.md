
# Project Multimedia - An Ordinary Zombie Game
Futsuu ni Zonbi Ge atau An Ordnary Zombie Game adalah sebuah game roguelike, di mana karakternya seorang penduduk desan bernama Yamato berusaha bertahan hidup selama mungkin dari Zombie Apocalypse.

Project ini merupakan pemenuhan tugas projek praktikum Multimedia, yaitu membuat 2D game dengan Unity.

## Developer
- Syakir Alamsyah
- Kristoforus Noventa
- Todo Christanto P.S.
- FX.Oktabimo DwiPriabudi Sumintro
- Rafa Fakhri Aldivi


## 📊 Mermaid Diagrams


```mermaid
graph TD
    A([Start Game]) --> B[Inisialisasi Player, Kamera, & Enemy Spawner]
    B --> C{Game Loop / Update Tiap Frame}
    
    %% Sistem Player & Kamera (Part 1)
    C --> D[Input Player WASD]
    D --> E[Gerakkan Player & Update Animasi/Arah Sprite]
    E --> F[Kamera Bergerak Mengikuti Player]
    
    %% Sistem Senjata (Part Sebelumnya)
    C --> G[Sistem Senjata]
    G --> H{Cooldown Serangan Selesai?}
    H -- Ya --> I[Keluarkan Serangan / Proyektil]
    H -- Tidak --> J[Tunggu Cooldown]
    I --> K[Cek Hit/Tabrakan Serangan dengan Musuh]
    
    %% Sistem Spawner Musuh (Part 7)
    C --> L[Sistem Enemy Spawner]
    L --> M{Waktu > Interval Wave?}
    M -- Ya --> N[Mulai Wave Baru & Hitung Kuota Musuh]
    M -- Tidak --> O{Waktu > Interval Spawn?}
    O -- Ya --> P{Jumlah Musuh Aktif < Batas Maksimal?}
    P -- Ya --> Q[Spawn Musuh di Titik Acak Luar Layar Layar]
    P -- Tidak --> R[Tunda Spawning]
    O -- Tidak --> S[Tunggu Interval Spawn]
    
    %% Sistem Perilaku Musuh
    C --> T[Sistem Musuh]
    T --> U[Musuh Terus Bergerak Mendekati Player]
    U --> V{Jarak Musuh Terlalu Jauh / Despawn Distance?}
    V -- Ya --> W[Relokasi Musuh ke Titik Spawn Dekat Player]
    V -- Tidak --> X{HP Musuh <= 0?}
    X -- Ya --> Y[Musuh Mati, Drop XP, Kurangi Jumlah Musuh Aktif]
    X -- Tidak --> Z{Musuh Menabrak Player?}
    Z -- Ya --> AA[Kurangi HP Player]
    
    %% Game Over State
    AA --> AB{HP Player <= 0?}
    AB -- Ya --> AC([Game Over])
    AB -- Tidak --> C
```


