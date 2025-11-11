using System;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Latihan : MonoBehaviour
{

    [SerializeField]

    //string[] nama = { "Yaya", "Yoyo", "Yuyu" };
    //List<string> nama = new List<string>();
    List<Player> players = new List<Player>();

    Player[] arrayPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerList();
        //cariSatuPlayerByLevel(15);
        cariBanyakPlayerByLevel(15);
    }

    void playerList()
    {
        players.Add(new Player("Sakura", 18, 343));
        players.Add(new Player("Kookie", 43, 7565));
        players.Add(new Player("Hana", 12, 210));
        players.Add(new Player("Riku", 20, 500));
        players.Add(new Player("Ken", 10, 100));

    }
    void cariSatuPlayerByLevel(int level)
    {
        Player p = players.Find(element => element.level > 15);
        Debug.Log(p.name);
    }

    void cariBanyakPlayerByLevel(int level)
    {
        List<Player> data = players.FindAll(elemenet => elemenet.level > 15);
        foreach (Player p in data)
        {
            Debug.Log($"Nama: {p.name}, Level: {p.level}, Health: {p.health}");
        }

    }
    // void tampilArrayList()
    // {
    //     nama.Add("Yaya");
    //     nama.Add("Yoyo");
    //     nama.Remove("Yaya");
    //     nama.Add("Yeye");
    //     nama.Insert(1, "Yuyu");
    //     string cari = nama.Find(nama => nama == "Yoyo");
    //     Debug.Log(cari);
    //     Boolean isExist = nama.Exists(nama => nama == "Yuyu");
    //     Debug.Log(isExist);
    // }

    void playerArray()
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
        // Player p1 = new Player();
        // p1.name = "Sakura";
        // p1.level = 18;
        // p1.health = 234;

        // Debug.Log("Player name : " + p1.name);
        // Debug.Log("Level : " + p1.level);
        // Debug.Log("Health : " + p1.health);

    }

    void mobil()
    {
        Car palisade = new Car("Palisade", "Black", 2025, "Listrik");
        palisade.output();

        Car ferrary = new Car("Ferrary", "Red", 2020, "Oil 98");
        ferrary.output();
    }




}


