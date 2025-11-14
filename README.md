# Kredensial Mikro Guru - H4
Kamis, 13 Nov 2025

1. Konsep Umum: Mouse Input Collection
Artinya: kita “mengumpulkan” input dari mouse — klik, posisi, arah gerakan, dan target — untuk mengendalikan aksi karakter atau objek.
Biasanya ini melibatkan:
￼<img width="544" height="83" alt="Input  GetMouseButtonDown(0)  klik kiri" src="https://github.com/user-attachments/assets/19395aae-650e-42c2-a475-6bcfcab4ea46" />
<img width="549" height="159" alt="Screenshot 2025-11-14 at 08 53 06" src="https://github.com/user-attachments/assets/41b700d5-ee3c-4006-ad19-033ecbca4031" />

Apa itu Coroutine
Coroutine adalah fungsi khusus di Unity yang bisa “berhenti sementara” (pause) di tengah jalan, lalu lanjut lagi setelah waktu tertentu — tanpa menghentikan game utama.
Cocok buat:
* Menunggu beberapa detik sebelum menjalankan aksi.
* Membuat animasi, efek delay, respawn, countdown.
* Menjalankan aksi berurutan tanpa pakai Update() yang berantakan.
<img width="369" height="191" alt="Screenshot 2025-11-14 at 08 53 32" src="https://github.com/user-attachments/assets/3d5d45a1-8581-4d2b-ac41-d673d11277aa" />

IEnumerator itu tipe fungsi khusus di C# dan Unity yang memungkinkan kamu membuat Coroutine — alias fungsi yang bisa dijalankan secara bertahap dengan jeda waktu di antara
IEnumerator = singkatan dari “Interface Enumerator”.
Dalam Unity, dia digunakan untuk menjalankan blok kode yang bisa di-pause sementara menggunakan yield return.

variabel GameObject di Unity, itu tipe data khusus untuk menampung referensi ke objek apa pun yang ada di scene atau prefab.

Cara mendapatkan posisi mouse:
- Input.mousePotition
- camera.main.ScreenToWorldPoint() > untuk konvert posisi

Physics2D.OverlapPoint(Vector2 point) → Mengecek apakah ada Collider2D di posisi dunia (world position) yang kita tentukan. Biasanya digunakan untuk:
* klik/tap pada objek,
* mendeteksi posisi sentuhan,
* atau memeriksa area tertentu pada game 2D
