using UnityEngine;
using UnityEngine.UI;

public class SlideShow : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public DatabaseGambar databaseGambar;
    public Image image; // object image
    public int index = 0;

    public void next()
    {
        if(index >= databaseGambar.listGambar.Count - 1)
        {
            index = 0;
        } else
        {
            index++;
        }        
        image.sprite = databaseGambar.listGambar[index];
    }

    public void previous()
    {
        if(index <= 0)
        {
            index = databaseGambar.listGambar.Count - 1;
        } else
        {
            index--;
        }
        image.sprite = databaseGambar.listGambar[index];
    }
}
