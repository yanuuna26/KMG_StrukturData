using TMPro;
using UnityEngine;

public class InteraksiGame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public SquareGame squareGame; // instansiasi square game agar bisa mengubah nilai arak gerak dari tombol onClick
    public int score; 
    public TMP_Text textScore; //instan obj text score
    
    //membuat method untuk dimasukkan ke onClick di button
    public void gerakAtas()
    {
        squareGame.arahGerak = ArahGerak.atas;
    }
    public void gerakBawah()
    {
        squareGame.arahGerak = ArahGerak.bawah;
    }
    public void gerakKanan()
    {
        squareGame.arahGerak = ArahGerak.kanan;
    }
    public void gerakKiri()
    {
        squareGame.arahGerak = ArahGerak.kiri;
    }
}
