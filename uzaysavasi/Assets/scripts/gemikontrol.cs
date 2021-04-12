using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gemikontrol : MonoBehaviour
{
    const float hareketgucu = 5;
    [SerializeField]
    GameObject kursunprefab;
    [SerializeField]
    GameObject patlamaprefab;
    oyunkontrolu ooyunkontrolu;

    // Start is called before the first frame update
    void Start()
    {
        ooyunkontrolu = Camera.main.GetComponent<oyunkontrolu>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        float yatayinput = Input.GetAxis("Horizontal");
        float dikeyinput = Input.GetAxis("Vertical");
        if (Input.GetAxis("Horizontal") != 0)
        {
            position.x += yatayinput * hareketgucu * Time.deltaTime;
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            position.y += dikeyinput * hareketgucu * Time.deltaTime;
        }
        transform.position = position;
        if(Input.GetButtonDown("Jump"))
        {
            GameObject.FindGameObjectWithTag("audio").GetComponent<seskontrol>().atess();
            Vector3 kursunposition = gameObject.transform.position;
            kursunposition.y += 1;
            Instantiate(kursunprefab, kursunposition, Quaternion.identity);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="asteroid")
        {
            GameObject.FindGameObjectWithTag("audio").GetComponent<seskontrol>().gemipatlatma();
            ooyunkontrolu.oyunubitir();
            Instantiate(patlamaprefab, gameObject.transform.position, Quaternion.identity);

            Destroy(gameObject);
        }
    }
}
