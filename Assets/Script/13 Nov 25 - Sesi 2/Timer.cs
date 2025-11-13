using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float waktu;
    public float maxWaktu;
    public TMP_Text textTimer;
    public bool waktuBerjalan = true;
    public KeyCode startWaktu, endWaktu;
    public Coroutine hitungTimerCoroutine;

    public Image progressFill;

    void Update()
    {
        if (Input.GetKeyDown(startWaktu))
        {
            if(hitungTimerCoroutine == null)
            {
                hitungTimerCoroutine = StartCoroutine(hitungTimer());
            }
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
            progressFill.fillAmount = waktu / maxWaktu;
            yield return new WaitForSeconds(1);    
        }
    }
}
