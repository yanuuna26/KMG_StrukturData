using UnityEngine;

public class SquareGame : MonoBehaviour
{
    public ArahGerak arahGerak = ArahGerak.kanan;
    public InteraksiGame interaksiGame;
    public float kecepatan = 3.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (arahGerak)
        {
            case ArahGerak.atas:
                gameObject.transform.Translate(0, kecepatan * Time.deltaTime, 0);
                break;
            case ArahGerak.bawah:
                gameObject.transform.Translate(0, -kecepatan * Time.deltaTime, 0);
                break;
            case ArahGerak.kanan:
                gameObject.transform.Translate(kecepatan * Time.deltaTime, 0, 0);
                break;
            case ArahGerak.kiri:
                gameObject.transform.Translate(-kecepatan * Time.deltaTime, 0, 0);
                break;
        }
    }
    public void tambahScore()
    {
        interaksiGame.textScore.text = "Score : " + interaksiGame.score;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("dinding"))
        {
            Debug.Log("Tabrak");
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
        interaksiGame.score++;
        tambahScore();
    }
}


public enum ArahGerak {
    atas,
    bawah,
    kiri,
    kanan
}