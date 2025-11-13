using UnityEngine;

public class PemainLompat : MonoBehaviour
{
    public float forceMultiplier = 10.0f;
    public bool diLantai;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Lompat()
    {
        if (diLantai)
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.AddForce(transform.up * forceMultiplier, ForceMode2D.Impulse);
        } else
        {
            
        }
        
    }

    void OnCollisionEnter2D(Collision2D collision) // cek apa object menyentuh lantai
    {
        if (collision.gameObject.CompareTag("lantai")) 
        {
            diLantai = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision) // cek apa object meninggalkan lantai
    {
        if (collision.gameObject.CompareTag("lantai"))
        {
            diLantai = false;
        }
    }
}
