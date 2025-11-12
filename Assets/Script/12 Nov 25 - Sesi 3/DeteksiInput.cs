using System;
using UnityEngine;
using UnityEngine.Events;

public class DeteksiInput : MonoBehaviour
{
    public Score score;
    //public Action<int> inputEvent; // event dari C#
    public UnityEvent inputEvent; //event dr Unity
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //score.AddScore();
            //panggil event 
            inputEvent.Invoke();
            

        }
    }
}
