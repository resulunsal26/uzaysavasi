using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class siraliyokedici : MonoBehaviour
{
    [SerializeField]
    GameObject astreoidprefab;
    GameObject uzaygemisi;
    List<GameObject> astreoidlist;
    GameObject hedefastreoid;
    void Start()
    {
        uzaygemisi = GameObject.FindGameObjectWithTag("Player");
        astreoidlist = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);
            GameObject astreoid = Instantiate(astreoidprefab, position, Quaternion.identity);
            astreoidlist.Add(astreoid);
        }
        if(Input.GetMouseButtonDown(1))
        {
            hedefiyoket();
        }
    }
    GameObject Enyakinastreoid()
    {
        GameObject enyakinastreoid;
        float enyakinmesafe;
        if(astreoidlist.Count==0)
        {
            return null;
        }
        else
        {
            enyakinastreoid = astreoidlist[0];
            enyakinmesafe = mesafeolcer(enyakinastreoid);
        }
        foreach(GameObject astreoid in astreoidlist)
        {
            float mesafe = mesafeolcer(astreoid);
            if(mesafe<enyakinmesafe)
            {
                enyakinmesafe = mesafe;
                enyakinastreoid = astreoid;
            }
        }
        return enyakinastreoid;
    }
    float mesafeolcer(GameObject hedef)
    {
        return Vector3.Distance(uzaygemisi.transform.position, hedef.transform.position);
    }
    public void hedefiyoket()
    {
        hedefastreoid = Enyakinastreoid();
        if(hedefastreoid!=null)
        {
            hedefastreoid.GetComponent<yokedici>().astreoidyokedici(1);
            astreoidlist.Remove(hedefastreoid);
        }
    }
   
}
