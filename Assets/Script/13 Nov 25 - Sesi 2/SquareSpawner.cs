using System.Collections;
using UnityEngine;

public class SquateSpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject spawnObject;
    public bool sedangSpawn = true;
    void Start()
    {
        StartCoroutine(munculObject());
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    IEnumerator munculObject()
    {
        while (sedangSpawn)
        {
            float setengahTinggi = Camera.main.orthographicSize;
            float setengahLebar = setengahTinggi * Camera.main.aspect;

            // Posisi acak dalam area kamera
            Vector3 randomPos = new Vector3(
                Random.Range(-setengahLebar, setengahLebar),
                Random.Range(-setengahTinggi, setengahTinggi),
                0f
            );
            Instantiate(spawnObject, randomPos, Quaternion.identity);
            yield return new WaitForSeconds(3);
        }
    }
}
