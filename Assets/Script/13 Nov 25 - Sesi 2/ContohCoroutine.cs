using System.Collections;
using UnityEngine;

public class ContohCoroutine : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(cobaCoroutine());
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Buat function IEnumertor untuk menggunakan coroutine
    IEnumerator cobaCoroutine()
    {
        Debug.Log("Perintah 1");
        yield return new WaitForSeconds(3);
        Debug.Log("Perintah 2");
    }
}
