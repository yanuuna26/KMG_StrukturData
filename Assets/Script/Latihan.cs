using UnityEngine;

public class Latihan : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cobaWhile(10);
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void cobaWhile(int nyawa)
    {
        Debug.Log("Awal nyawa : " + nyawa);
        while(nyawa > 0)
        {
            nyawa -= 1;
            Debug.Log(nyawa);
        }
    }
}


