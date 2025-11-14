# Kredensial Mikro Guru - H3
Rabu, 12 Nov 2025

UnityEvent
ScriptableObject
Implementasi UI
Invocation Method
onEnable dan onDisable
<img width="673" height="156" alt="Screenshot 2025-11-14 at 08 49 48" src="https://github.com/user-attachments/assets/eed3e907-1642-4896-a409-628ed94fcac2" />

Urutan Eksekusi (Lifecycle)
Contoh urutan umum dalam Unity:
1. Awake() → saat GameObject dibuat di scene
2. OnEnable() → saat aktif pertama kali
3. Start() → setelah OnEnable(), sebelum frame pertama berjalan
4. Update() → setiap frame
5. OnDisable() → saat nonaktif atau dihancurkan
6. OnDestroy() → saat benar-benar dihapus dari memori
🧠 Jadi OnEnable() dan OnDisable() bisa dipanggil berkali-kali, misalnya saat GameObject diaktifkan/dinonaktifkan lewat tombol atau script.

Hal yang Perlu Dihindari
1. Jangan akses variabel null di OnDisable() → bisa menimbulkan NullReferenceException.
2. Urutan aktif/nonaktif: kadang GameManager lebih dulu nonaktif dari Score, jadi aman kalau pakai pengecekan: 
3. ￼<img width="412" height="83" alt="if (GameManager  Instance!= null)" src="https://github.com/user-attachments/assets/2499f9e8-3813-4e1b-8ca0-6cac5d483019" />
4. Hindari logika berat di OnEnable() atau OnDisable() (misalnya load file besar) — sebaiknya dipisah ke method lain.

Kesimpulan
<img width="546" height="156" alt="Screenshot 2025-11-14 at 08 50 27" src="https://github.com/user-attachments/assets/66637df1-6a99-4e98-b8ff-f56ba7801692" />

“Setting Canvas di Unity di awal” itu penting supaya tampilan UI (teks, tombol, gambar, dsb.) tampil proporsional di semua resolusi layar, terutama kalau project-nya untuk game mobile atau desktop.

ScriptableObject adalah objek data di luar scene yang bisa menyimpan informasi permanen (seperti database).
Berbeda dengan MonoBehaviour, dia tidak harus ditempel di GameObject, tapi disimpan sebagai asset (.asset) di folder Assets.
<img width="371" height="204" alt="Screenshot 2025-11-14 at 08 50 49" src="https://github.com/user-attachments/assets/1005fb89-3b24-442f-8067-a79212211a88" />

Rigidbody di Unity adalah komponen yang memberikan efek fisika ke GameObject — seperti gravitasi, tumbukan (collision), dan gaya (force).
Tapi perilaku fisikanya tergantung dari Body Type-nya: 👉 Dynamic, Kinematic, atau Static
1. Rigidbody Dynamic
🎯 Dipakai untuk objek yang bergerak dengan fisika.
🧠 Karakteristik:
* Terpengaruh gravitasi
* Bisa didorong oleh force, AddForce(), atau tabrakan
* Dapat bergerak bebas di dunia fisika Unity
* Collider-nya ikut dihitung oleh sistem fisika
🧱 Contoh:
* Bola jatuh ke tanah
* Mobil yang berjalan
* Player yang bisa melompat
2. Rigidbody Kinematic
🎯 Dipakai untuk objek yang bergerak tapi tidak dikontrol oleh fisika.
🧠 Karakteristik:
* Tidak terpengaruh gravitasi
* Tidak bereaksi terhadap gaya atau tabrakan
* Tapi tetap bisa menabrak objek Dynamic
* Gerakannya diatur lewat transform.position atau MovePosition()
🧱 Contoh:
* Pintu yang terbuka secara animasi
* Platform bergerak di game 2D/3D
* Elevator yang naik turun
3. Rigidbody Static
🎯 Dipakai untuk objek yang diam dan tidak akan pernah bergerak.
🧠 Karakteristik:
* Tidak bisa bergerak sama sekali
* Tidak bisa menerima gaya
* Tapi tetap bisa ditabrak oleh objek Dynamic
* Sangat efisien (tidak perlu dihitung fisikanya terus-menerus)
🧱 Contoh:
* Tanah
* Dinding
* Lantai, tembok, tiang

enumerator
enum (enumeration) di C# — yaitu tipe data khusus yang berisi sekumpulan nilai tetap (konstan) yang bisa dipilih.
