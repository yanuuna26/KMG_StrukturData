using UnityEngine;

public class Score : MonoBehaviour
{

    [SerializeField]
    int score;
    DeteksiInput objectDeteksi;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        objectDeteksi.inputEvent += AddScore;
    }

    void OnDisable()
    {
        objectDeteksi.inputEvent -= AddScore;
    }

    public void AddScore()
    {
        score++;
    }
}
