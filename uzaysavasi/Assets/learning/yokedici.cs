using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yokedici : MonoBehaviour
{
    [SerializeField]
    private GameObject patlamaprefab;
    timer timer;
    void Start()
    {
        timer = gameObject.AddComponent<timer>();
      
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.bitti)
        {
           GameObject patlama= Instantiate(patlamaprefab,transform.position,Quaternion.identity);
            Destroy(gameObject);
         
        }
    }
    public void astreoidyokedici(int sure)
    {
        timer.toplamsure = sure;
        timer.calistir();
    }
}
