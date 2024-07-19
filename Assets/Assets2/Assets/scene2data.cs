using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scene2data : MonoBehaviour
{
    // Start is called before the first frame update

    public Data data;
    public TMP_Text points;



    void Start()
    {
        Data[] datas = FindObjectsOfType<Data>();
        if (datas.Length > 0)
        {
            data = datas[0];
        }
        else
        {
            Debug.LogError("No Data instances found in the scene.");
        }
    }
        
    

    // Update is called once per frame
    void Update()
    {
        if (data != null && points != null)
        {
            points.text = $"Points : {data.points}";
        }
        else
        {
            if (data == null)
            {
                Debug.LogError("Data instance is null.");
            }
            if (points == null)
            {
                Debug.LogError("Points TMP_Text is null.");
            }
        }
    }
}
