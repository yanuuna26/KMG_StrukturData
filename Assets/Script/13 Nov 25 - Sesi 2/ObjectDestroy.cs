using UnityEngine;

public class ObjectDestroy : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Vector2 posisiKlik = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D objectTerdeteksi = Physics2D.OverlapPoint(posisiKlik);

            if(objectTerdeteksi != null)
            {
                Destroy(objectTerdeteksi.gameObject);
            }

        }
    }
}
