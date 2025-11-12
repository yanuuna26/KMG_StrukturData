using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AksiTombol : MonoBehaviour
{
    public Sprite asset; // gambar yg mau masuk ke object
    public Image image; // object image
    public TMP_Text text; // komponen object text
    public void aksi()
    {
        Debug.Log("Test");
        text.text = "SELAMAT SIANGG!!";
        image.sprite = asset;
    }
}
