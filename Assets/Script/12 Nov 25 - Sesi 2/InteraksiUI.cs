using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteraksiUI : MonoBehaviour
{

    public SquareMove squareMove;
    public GameObject squareWarna;
    public TMP_Text kataBerubah;
    public TMP_Text namaBerubah;
    public List<string> daftarNama;
    public int idNama = -1;
    public void ubahKataKiri()
    {
        string kata = "Kiri";
        kataBerubah.text = kata;
    }

    public void ubahKataKanan()
    {
        string kata = "Kanan";
        kataBerubah.text = kata;
    }
    
    public void lanjutNama()
    {
        if (idNama < daftarNama.Count - 1)
        {
            idNama++;
        }
        else
        {
            idNama = 0;
        }
        namaBerubah.text = daftarNama[idNama];
    }
    public void kembaliNama()
    {
        if (idNama <= 0)
        {
            idNama = daftarNama.Count - 1;
        }
        else
        {
            idNama--;
        }
        namaBerubah.text = daftarNama[idNama];
    }

    public void ubahWarna(Color warna)
    {
        SpriteRenderer spriteRenderer = squareWarna.GetComponent<SpriteRenderer>();
        spriteRenderer.color = warna;
    }

    public void ubahMerah()
    {
        ubahWarna(Color.red);
    }
    public void ubahBiru()
    {
        ubahWarna(Color.blue);
    }
    public void ubahHijau()
    {
        ubahWarna(Color.green);
    }
    public void ubahRandomWarna()
    {
        Color color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        ubahWarna(color);
    }

    public void mulai()
    {
        squareMove.isMove = true;
    }
    public void berhenti()
    {
        squareMove.isMove = false;
    }
    public void keKanan()
    {
        squareMove.isMoveRight = true;
    }
    public void keKiri()
    {
        squareMove.isMoveRight = false;
    }
}
