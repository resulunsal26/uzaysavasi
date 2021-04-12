using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timertest : MonoBehaviour
{
    timer timer;
    float baslangiczamani;

    void Start()
    {
        timer = gameObject.AddComponent<timer>();
        timer.Toplamsure = 3;
        timer.calistir();
        baslangiczamani = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer.bitti)
        {
            float gecensure = Time.time - baslangiczamani;
            Debug.Log(gecensure);
            baslangiczamani = Time.time;
            timer.calistir();
        }
    }
}
