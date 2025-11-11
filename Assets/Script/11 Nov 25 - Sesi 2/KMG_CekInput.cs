
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject _munculHilang;
    public GameObject _untukSpawn;
    public GameObject _targetHancur;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Input.GetKeyDown(KeyCode);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Spasi di tekan");
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            _munculHilang.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            _munculHilang.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {

            Vector3 posisi = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0);
            Quaternion rotasi = Quaternion.Euler(0, 0, Random.Range(0, 360));
            GameObject objBaru = Instantiate(_untukSpawn, posisi, rotasi);
            Renderer rend = objBaru.GetComponent<Renderer>();
            rend.material.color = Random.ColorHSV(0f, 1f, 0.6f, 1f, 0.6f, 1f);
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            GameObject hancurkan = GameObject.FindGameObjectWithTag("sasaran");
            Destroy(hancurkan);
        }
    }
}
