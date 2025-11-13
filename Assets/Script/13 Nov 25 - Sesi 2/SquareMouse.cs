using UnityEngine;

public class SquareMouse : MonoBehaviour
{
    // Update is called once per frame
    public Transform cubeTransform;
    public Vector2 posisiKlik;
    void Update()
    {

        //Debug.Log(Input.mousePosition); // posisi mouse di screen, bukan di dalam scene atau dunia object
        //Camera.main.ScreenToWorldPoint(Input.mousePosition); cara convert lokasi mouse ke dalam scene

        //disimpan di variabel vektor
        //Vector2 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); 
        //ikut posisi mouse
        //cubeTransform.position = worldMousePos; 

        // mengejar mouse
        //cubeTransform.position = Vector2.MoveTowards(cubeTransform.position, worldMousePos, 0.1f); 

        //ambil posisi klik
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            posisiKlik = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        //geser ke posisi klik
        cubeTransform.position = Vector2.MoveTowards(cubeTransform.position, posisiKlik, 0.05f);
    
    }
}
