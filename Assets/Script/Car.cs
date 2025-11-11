using UnityEngine;

[System.Serializable]
public class Car
{
    public string merk;
    public string warna;
    public int tahun;
    public string bbm;

    public Car(string merk, string warna, int tahun, string bbm)
    {
        this.merk = merk;
        this.warna = warna;
        this.tahun = tahun;
        this.bbm = bbm;

    }

    public void output()
    {
        Debug.Log("Merk mobil : " + merk + "\n"
                + "Warna : " + warna + "\n"
                + "Tahun keluaran : " + tahun + "\n"
                + "BBM : " + bbm);
    }
}
