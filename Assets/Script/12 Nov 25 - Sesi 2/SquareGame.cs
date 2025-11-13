using UnityEngine;

public class SquareGame : MonoBehaviour
{
    public ArahGerak arahGerak = ArahGerak.kanan; // instansiasi nilai awal arah gerak
    public InteraksiGame interaksiGame; //instansiasi interaksi game
    public float kecepatan = 3.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (arahGerak) // cek arah gerak di method update
        {
            //translate (x, y, z) > (kanan-kiri, atas-bawah, dekat-jauh)
            case ArahGerak.atas: //case arah ke atas, 
                //translate ke atas > (0, +y, 0)
                gameObject.transform.Translate(0, kecepatan * Time.deltaTime, 0);
                break;
            case ArahGerak.bawah:
                //case arah ke bawah, 
                //translate ke atas > (0, -y, 0)
                gameObject.transform.Translate(0, -kecepatan * Time.deltaTime, 0);
                break;
            case ArahGerak.kanan:
                //case arah ke kanan, 
                //translate ke atas > (+x, 0, 0)
                gameObject.transform.Translate(kecepatan * Time.deltaTime, 0, 0);
                break;
            case ArahGerak.kiri:
                //case arah ke kanan, 
                //translate ke atas > (-x, 0, 0)
                gameObject.transform.Translate(-kecepatan * Time.deltaTime, 0, 0);
                break;
        }
    }
    public void tambahScore()
    {
        //memberi nilai di textScore di interaksi game
        interaksiGame.textScore.text = "Score : " + interaksiGame.score;
    }
    void OnCollisionEnter2D(Collision2D collision) //jika terjadi sentuhan antar rigidbody2D
    {
        if (collision.gameObject.CompareTag("dinding")) // jika menyentuh obj dg tag dinding
        {
            // Debug.Log("Tabrak");
            //memindah arah gerak ke arah sebaliknya
            if (arahGerak == ArahGerak.atas)
            {
                arahGerak = ArahGerak.bawah;
            }
            else if (arahGerak == ArahGerak.bawah)
            {
                arahGerak = ArahGerak.atas;
            }
            else if (arahGerak == ArahGerak.kanan)
            {
                arahGerak = ArahGerak.kiri;
            }
            else
            {
                arahGerak = ArahGerak.kanan;
            }
        }
        //nilai skore ++
        interaksiGame.score++;
        tambahScore();
    }
}


//membuat konstan variabel menggunakan enum.
public enum ArahGerak
{
    atas,
    bawah,
    kiri,
    kanan
}