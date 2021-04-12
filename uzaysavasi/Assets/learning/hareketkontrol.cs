using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareketkontrol : MonoBehaviour
{
    float colliderboyyarim;
    float colliderenyarim;
    void Start()
    {
        Rigidbody2D myrigidbody2D = GetComponent<Rigidbody2D>();
        myrigidbody2D.AddForce(new Vector2(Random.Range(-5, 5),Random.Range(-5,5)),ForceMode2D.Impulse);
        BoxCollider2D collider = GetComponent<BoxCollider2D>();
        colliderboyyarim = collider.size.y / 2;
        colliderenyarim = collider.size.x / 2;
    }

   
    void Update()
    {
        //Vector3 position = Input.mousePosition;
        //position.z = -Camera.main.transform.position.z;
        //position = Camera.main.ScreenToWorldPoint(position);
        //transform.position = position;
        //ekrandakal();
    }
    void ekrandakal()
    {
        Vector3 position = transform.position;
        if(position.x-colliderenyarim<=ekranhesaplayici.Sol)
        {
            position.x = ekranhesaplayici.Sol + colliderenyarim;
        }
        else if(position.x+colliderenyarim>ekranhesaplayici.Sag)
        {
            position.x = ekranhesaplayici.Sag - colliderenyarim;
        }
         if (position.y + colliderboyyarim >ekranhesaplayici.Ust)
        {
            position.y = ekranhesaplayici.Ust - colliderboyyarim;
        }
        else if (position.y - colliderboyyarim < ekranhesaplayici.Alt)
        {
            position.y = ekranhesaplayici.Alt + colliderboyyarim;
        }
        transform.position = position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
