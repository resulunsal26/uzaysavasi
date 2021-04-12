using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toplayici : MonoBehaviour
{
    [SerializeField] GameObject yildizprefab;
    List<GameObject> yildizlar = new List<GameObject>();
    public GameObject hedefyildiz
    {
         get
        {
            if(yildizlar.Count>0)
            {
                return yildizlar[0];
            }
            else
            {
                return null;
            }
        }
    }
   

    
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Vector3 positipn = Input.mousePosition;
            positipn.z = -Camera.main.transform.position.z;
            Vector3 oyundunyapozisyon = Camera.main.ScreenToWorldPoint(positipn);
            yildizlar.Add(Instantiate(yildizprefab, oyundunyapozisyon, Quaternion.identity));

        }
    }
    public void yildizyokey(GameObject yokedilecelyildiz)
    {
        yildizlar.Remove(yokedilecelyildiz);
        Destroy(yokedilecelyildiz);
    }
}
