using System;
using UnityEngine;

[System.Serializable]
public class Latihan : MonoBehaviour
{

    [SerializeField]

    //string[] nama = { "Yaya", "Yoyo", "Yuyu" };

    Player[] arrayPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        players();
    }

    // void tampilArray()
    // {
    //     for (int i = 0; i < nama.Length; i++)
    //     {
    //         Debug.Log("Nama " + (i + 1) + " : " + nama[i]);
    //     }
    // }

    void players()
    {
        foreach (Player p in arrayPlayer)
        {
            Debug.Log("Nama player : " + p.name + "\n"
                    + "Level : " + p.level + "\n"
                    + "Health : " + p.health);
        }
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

    void cobaOOP()
    {
        Player p1 = new Player();
        p1.name = "Sakura";
        p1.level = 18;
        p1.health = 234;

        Debug.Log("Player name : " + p1.name);
        Debug.Log("Level : " + p1.level);
        Debug.Log("Health : " + p1.health);

    }

    void mobil()
    {
        Car palisade = new Car("Palisade", "Black", 2025, "Listrik");
        palisade.output();

        Car ferrary = new Car("Ferrary", "Red", 2020, "Oil 98");
        ferrary.output();
    }




}


