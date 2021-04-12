using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uıkontrol : MonoBehaviour
{
    [SerializeField]
    GameObject oyunaditxt=default;
    [SerializeField]
    GameObject oyunbittitxt = default;
    [SerializeField]
    Text skortxt = default;
    [SerializeField]
    GameObject oynabtn = default;
    int puan;
    // Start is called before the first frame update
    void Start()
    {
        oyunbittitxt.gameObject.SetActive(false);
        skortxt.gameObject.SetActive(false);
    }
    public void oyunbasladi()
    {
        puan = 0;
        oyunaditxt.gameObject.SetActive(false);
        oynabtn.gameObject.SetActive(false);
        skortxt.gameObject.SetActive(true);
        oyunbittitxt.gameObject.SetActive(false);
        puaniguncelle();

    }
    public void oyunbitti()
    {
        oyunbittitxt.gameObject.SetActive(true);
        oynabtn.gameObject.SetActive(true);
       

    }
    void puaniguncelle()
    {
        skortxt.text = "Puan : " + puan;
    }
   public void asteroidyokoldu(GameObject asteroid)
    {
        switch(asteroid.gameObject.name[8])
        {
            case '1': puan += 5; puaniguncelle();break;
            case '2': puan += 10; puaniguncelle(); break;
            case '3': puan += 15; puaniguncelle(); break;
        }
      
       
    }
}
