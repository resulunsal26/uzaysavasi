using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour
{
    [SerializeField]
    GameObject patlamaprefab;
    Rigidbody2D rb;
    oyunkontrolu Osyunkontrolu;
    void Start()
    {
        Osyunkontrolu = Object.FindObjectOfType<oyunkontrolu>();
        rb = GetComponent<Rigidbody2D>();
        float yon = Random.Range(0f, 1f);
        if(yon<0.5)
        {
            rb.AddForce(new Vector2(Random.Range(-2.5f, -1.0f), Random.Range(-2.5f, -1.0f)), ForceMode2D.Impulse);
            rb.AddTorque(yon * 10.0f);
        }
        else
        {
            rb.AddForce(new Vector2(Random.Range(1.0f, 2.5f), Random.Range(-2.5f, -1.0f)), ForceMode2D.Impulse);
            rb.AddTorque(-yon * 10.0f);
        }
       
      
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag=="kursun")
        {
            GameObject.FindGameObjectWithTag("audio").GetComponent<seskontrol>().asteroidpatlama();
            Osyunkontrolu.asteroidyokoldu(gameObject);

            astreoidyoket();
        }
    }
    public void astreoidyoket()
    {
        Instantiate(patlamaprefab, gameObject.transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
   

}
