using System.Collections;
using UnityEngine;

public class PenghapusObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // StartCoroutine(hapusObject());
        Destroy(gameObject, 3); // tidak pake coroutine
    }

    // Update is called once per frame
    void Update()
    {

    }
}
    
//     IEnumerator hapusObject()
//     {
//         yield return new WaitForSeconds(4);
//         Destroy(gameObject);
//     }
// }
