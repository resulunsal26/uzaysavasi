using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunkontrolu : MonoBehaviour
{
    [SerializeField] GameObject uzaygemisiprefab;
    GameObject uzaygemisi;
    [SerializeField]
    List<GameObject> astreoidprefabs = new List<GameObject>();
    List<GameObject> asteroidlist = new List<GameObject>();
    [SerializeField]
    int zorluk = 1;
    [SerializeField]
    int carpan = 5;
    uıkontrol uıkontrol;
    void Start()
    {
        uıkontrol = GetComponent<uıkontrol>();
       
    }
   public void oyunubaslat()
    {
        uıkontrol.oyunbasladi();
        uzaygemisi = Instantiate(uzaygemisiprefab);
        uzaygemisi.transform.position = new Vector3(0, ekranhesaplayici.Alt + 1.5f);
        asteroiduret(5);
    }
   
    void asteroiduret(int adet)
    {
        Vector3 position = new Vector3();
        for (int i = 0; i < adet; i++)
        {
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);
            position.x = Random.Range(ekranhesaplayici.Sol, ekranhesaplayici.Sag);
            position.y = ekranhesaplayici.Ust-1.5f;
            GameObject asteroid = Instantiate(astreoidprefabs[Random.Range(0, 3)], position, Quaternion.identity);
            asteroidlist.Add(asteroid);
        }
    }
    public void asteroidyokoldu(GameObject asteroid)
    {
        uıkontrol.asteroidyokoldu(asteroid);
        asteroidlist.Remove(asteroid);
        if(asteroidlist.Count<=zorluk)
        {
            zorluk++;
            asteroiduret(zorluk * carpan);
        }
    }
    public void oyunubitir()
    {
        foreach(GameObject asteroid in asteroidlist)
        {
            asteroid.GetComponent<asteroid>().astreoidyoket();
        }
        asteroidlist.Clear();
        zorluk = 1;
        uıkontrol.oyunbitti();
    }
}
