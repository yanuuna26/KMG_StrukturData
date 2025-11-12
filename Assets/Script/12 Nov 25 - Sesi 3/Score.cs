using UnityEngine;

public class Score : MonoBehaviour
{
    public int score;
    public DeteksiInput objectDeteksi;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        objectDeteksi.inputEvent += AddScore;
    }

    public void AddScore()
    {
        score++;
    }
    void OnDisable()
    {
        objectDeteksi.inputEvent -= AddScore;
    }

    
}
