using UnityEngine;
using UnityEngine.UIElements;

public class SquareGerakScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(3 * Time.deltaTime, 0, 0);
        gameObject.transform.Rotate(0, 0, 100 * Time.deltaTime);
        gameObject.transform.localScale += new Vector3(0.3f, 0.3f, 0) * Time.deltaTime;
        gameObject.SetActive(false);
    }
}
