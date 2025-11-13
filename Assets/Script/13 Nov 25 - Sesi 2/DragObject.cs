using System.Text.RegularExpressions;
using UnityEngine;

public class DragObject : MonoBehaviour
{

    // void OnMouseEnter()
    // {
    //     Debug.Log("enter");
    // }

    // void OnMouseDown()
    // {
    //      Debug.Log("down");
    // }

    // void OnMouseExit()
    // {
    //      Debug.Log("exit");
    // }

    void OnMouseDrag()
    {
        //Debug.Log("drag");
        float setengahTinggi = Camera.main.orthographicSize;
        float setengahLebar = setengahTinggi * Camera.main.aspect;
        Vector2 posisiMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 posisiKananKiri = new Vector2(posisiMouse.x, transform.position.y); //drag kanan kiri saja
        posisiKananKiri.x = Mathf.Clamp(posisiKananKiri.x, -setengahLebar, setengahLebar); //drag kanan kiri sesuai ukuran scene
        transform.position = posisiKananKiri;

        // Vector2 minimum = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
            // ScreenToWorldPoint() = konversi posisi layar → posisi dunia.
            // (0,0,0) = pojok kiri bawah layar.
            // minimum sekarang menyimpan posisi dunia paling kiri yang terlihat kamera.
        // Vector2 maximum = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0));
            // Screen.width = lebar layar dalam pixel (misal 1920).
            // (Screen.width, 0) = pojok kanan bawah layar.
            // maximum menyimpan posisi dunia paling kanan dari kamera.
        // posisiKananKiri.x = Mathf.Clamp(posisiKananKiri.x, minimum.x, maximum.x);
    }
}

