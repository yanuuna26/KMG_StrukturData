using System;
using UnityEngine;

public class Latihan : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(factorial(4));
    }

    // Update is called once per frame
    void Update()
    {

    }

    void cobaWhile(int nyawa)
    {
        Debug.Log("Awal nyawa : " + nyawa);
        while (nyawa > 0)
        {
            nyawa -= 1;
            Debug.Log(nyawa);
        }
    }

    void cobaFor(int hit)
    {
        for (int i = 1; i <= hit; i++)
        {
            Debug.Log("Pukulan ke : " + i);
        }
    }

    int factorial(int angka)
    {
        int hasil = angka;
        String penjabaran = angka + "! = 4 x ";
        for (int i = angka - 1; i > 0; i--)
        {
            penjabaran += i + " x ";
            hasil = hasil * i;
        }
        Debug.Log(penjabaran);
        return hasil;
    }
    
    void segitiga(int tinggi)
    {
        String hasil = "";
        for (int i = 1; i <= tinggi; i++)
        {
            for (int a = 1; a <= i; a++)
            {
                hasil += "* ";
            }
            hasil += "\n";
        }

        Debug.Log(hasil);
    }
}


