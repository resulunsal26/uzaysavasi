using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uzaygemisikontrol : MonoBehaviour
{
    const float hareketgucu = 10;
    bool topluyor = false;
    GameObject hedef;
    Rigidbody2D myrigidbody;
    toplayici toplayici;

    // Start is called before the first frame update
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
        toplayici = Camera.main.GetComponent<toplayici>();
    }
    private void OnMouseDown()
    {
        if(!topluyor)
        {
            gitvetopla();
        }
    }
    void gitvetopla()
    {
        hedef = toplayici.hedefyildiz;
        if(hedef!=null)
        {
            Vector2 gidilecekyer = new Vector2(hedef.transform.position.x - transform.position.x, hedef.transform.position.y - transform.position.y);
            gidilecekyer.Normalize();
            myrigidbody.AddForce(gidilecekyer * hareketgucu, ForceMode2D.Impulse);
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject==hedef)
        {
            toplayici.yildizyokey(hedef);
            myrigidbody.velocity = Vector2.zero;
            gitvetopla();
        }
    }
    // Update is called once per frame
    void Update()
    {
    //    Vector3 position = transform.position;
    //    float yatayinput = Input.GetAxis("Horizontal");
    //    float dikeyinput = Input.GetAxis("Vertical");
    //    if (Input.GetAxis("Horizontal") !=0)
    //    {
    //        position.x += yatayinput * hareketgucu * Time.deltaTime;
    //    }
    //    if (Input.GetAxis("Vertical") !=0)
    //    {
    //        position.y += dikeyinput * hareketgucu * Time.deltaTime;
    //    }
    //    transform.position = position;
    }
}
