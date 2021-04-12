using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kursun : MonoBehaviour
{
    timer timer;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 10f), ForceMode2D.Impulse);
        timer = gameObject.AddComponent<timer>();
        timer.toplamsure = 3;
        timer.calistir();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer.bitti)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "asteroid")
        {
          
            Destroy(gameObject);
        }
    }
}
