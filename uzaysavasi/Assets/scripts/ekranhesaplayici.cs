using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ekranhesaplayici 
{
    static float sol,sag,ust,alt;
    //ekranın sol kenarının kordinatlarını verir
    public static float Sol
    {
        get
        {
            return sol;
        }
    }
    //ekranın sag kenarının kordinatlarını verir
    public static float Sag
    {
        get
        {
            return sag;
        }
    }
    //ekranın sol kenarının kordinatlarını verir
    public static float Ust
    {
        get
        {
            return ust;
        }
    }
    //ekranın sol kenarının kordinatlarını verir
    public static float Alt
    {
        get
        {
            return alt;
        }
    }
    public static void Init()
    {
        float ekrazekseni = Camera.main.transform.position.z;
        Vector3 solaltkose = new Vector3(0, 0, ekrazekseni);
        Vector3 sagustkose = new Vector3(Screen.width, Screen.height, ekrazekseni);
        Vector3 solaltkoseoyundunyasi = Camera.main.ScreenToWorldPoint(solaltkose);
        Vector3 sagustkoseoyundunyasi = Camera.main.ScreenToWorldPoint(sagustkose);
        sol = solaltkoseoyundunyasi.x;
        sag = sagustkoseoyundunyasi.x;
        ust = sagustkoseoyundunyasi.y;
        alt = solaltkoseoyundunyasi.y;
    }
}
