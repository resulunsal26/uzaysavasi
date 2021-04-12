using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patlamayokedici : MonoBehaviour
{
    timer timer;
   
    // Start is called before the first frame update
    void Start()
    {
       
        timer = gameObject.AddComponent<timer>();
        timer.Toplamsure = 1;
        timer.calistir();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.bitti)
        {
           
            Destroy(gameObject);
           
        }
    }
}
