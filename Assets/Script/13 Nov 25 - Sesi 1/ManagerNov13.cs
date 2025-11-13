using TMPro;
using UnityEngine;

public class ManagerNov13 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TMP_Text textAngka;
    public SquareMove13Nov squareMove13Nov;
    public int angka;
    public GameObject bolaJatuh;
    public PemainLompat pemainLompat;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Posisi mouse ada di : " + ambilPosisiMouse());
            ubahAngka(0);
            squareMove13Nov.isMove = true;
            squareMove13Nov.isMoveRight = false;
            munculDariAtas();
            pemainLompat.Lompat();
        }
        else if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Posisi mouse ada di : " + ambilPosisiMouse());
            ubahAngka(1);
            squareMove13Nov.isMove = true;
            squareMove13Nov.isMoveRight = true;
        }

        //kotak gerak
        if (squareMove13Nov.isMove)
        {
            if (squareMove13Nov.isMoveRight)
            {
                // ke kanan
                squareMove13Nov.gameObject.transform.Translate(squareMove13Nov.kecepatan * Time.deltaTime, 0, 0);
            }
            else
            {
                // ke kiri
                squareMove13Nov.gameObject.transform.Translate(-squareMove13Nov.kecepatan * Time.deltaTime, 0, 0);
            }
        }
    }

    public void ubahAngka(int angka)
    {
        if (angka == 0)
        {
            angka++;
        }
        else if (angka == 1)
        {
            angka--;
        }
        textAngka.text = "ANGKA : " + angka;
    }

    public string ambilPosisiMouse()
    {
        Vector3 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        return vector.ToString();
        //mengambil posisi dimana mouse diklik
    }

    public void munculDariAtas()
    {
        Vector3 posisiKlik = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 titikAtas = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0));
        Vector3 tempatJatuh = new Vector3(posisiKlik.x, titikAtas.y, 0);
        //memunculkan object dg nama bolaJatuh di tempayJatuh, dg rotasi Quaternion
        Instantiate(bolaJatuh, tempatJatuh, Quaternion.identity); 
    }
}
