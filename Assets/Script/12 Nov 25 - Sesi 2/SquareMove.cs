using UnityEngine;

public class SquareMove : MonoBehaviour
{

    public bool isMoveRight = true;
    public float kecepatan = 3.0f;
    public bool isMove = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        //bergerak
        if (isMove)
        {
            if (isMoveRight)
            {
                // ke kanan
                gameObject.transform.Translate(kecepatan * Time.deltaTime, 0, 0);
            } else
            {
                // ke kiri
                gameObject.transform.Translate(-kecepatan * Time.deltaTime, 0, 0);
            }
        }
        //diam
        else
        {
            gameObject.transform.Translate(0, 0, 0);
        }
    }
}
