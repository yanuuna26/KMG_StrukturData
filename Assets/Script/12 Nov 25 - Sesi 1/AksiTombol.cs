using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class AksiTombol : MonoBehaviour
{
    public Sprite asset; // gambar yg mau masuk ke object
    public Image image; // object image
    public TMP_Text text; // komponen object text
    public void aksi()
    {
        // Debug.Log("Test");
        // text.text = "SELAMAT SIANGG!!";
        // image.sprite = asset;

        SceneManager.LoadScene("Rabu, 12 Non UI - 2");
    }
}   
