using TMPro;
using UnityEngine;

public class InteraksiGame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public SquareGame squareGame;
    public int score;
    public TMP_Text textScore;
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {

    }

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
