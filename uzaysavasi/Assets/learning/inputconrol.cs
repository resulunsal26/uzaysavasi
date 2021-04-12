using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputconrol : MonoBehaviour
{
    List<GameObject> astreoidlist = new List<GameObject>();
    [SerializeField]
    GameObject astreoid;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);
            for (int i = 0; i < 20; i++)
            {
              astreoidlist.Add( Instantiate(astreoid, position, Quaternion.identity));
            }
          
            
        }
       /* if (Input.GetMouseButton(0))
        {

        }
        */if (Input.GetMouseButtonDown(1))
        {
            for (int i = 0; i < astreoidlist.Count; i++)
            {
                Destroy(astreoidlist[i]);
            }
            astreoidlist.Clear();
        }/*
        if (Input.GetMouseButton(2))
        {

        }*/
    }
    }
