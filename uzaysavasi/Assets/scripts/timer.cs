using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
   public float toplamsure=0;
    public float gecensure=0;
    bool calisiyor, basladi;
    public float Toplamsure
    {
        set
        {
            if(!calisiyor)
            {
                toplamsure = value;
            }
        }
    }
    public bool bitti
    {
        get
        {
            return basladi && !calisiyor;
        }
    }
    public void calistir()
    {
        if(toplamsure>0)
        {
            calisiyor = true;
            basladi = true;
            gecensure = 0;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(calisiyor)
        {
            gecensure += Time.deltaTime;
            if(gecensure>=toplamsure)
            {
                calisiyor = false;
            }
        }
    }
}
