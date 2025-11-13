using System.Collections;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public int waktu;
    public TMP_Text textTimer;
    public bool waktuBerjalan = true;
    public KeyCode startWaktu, endWaktu;
    public Coroutine hitungTimerCoroutine;

    void Update()
    {
        if (Input.GetKeyDown(startWaktu))
        {
            hitungTimerCoroutine = StartCoroutine(hitungTimer());
        }
        if (Input.GetKeyDown(endWaktu))
        {
            if(hitungTimerCoroutine != null)
            {
                StopCoroutine(hitungTimerCoroutine);
            }
        }
    }
    IEnumerator hitungTimer()
    {
        while (waktuBerjalan)
        {
            waktu++;
            textTimer.text = waktu.ToString();
            yield return new WaitForSeconds(1);    
        }
    }
}
