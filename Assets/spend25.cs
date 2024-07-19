using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using TMPro;
using System;

public class spend25 : MonoBehaviour
{
    public Data data;
    public Button button;


    // Start is called before the first frame update
    void Start()
    {
      

        button.onClick.AddListener(spending);
    }

    // Update is called once per frame
    public void spending()
    {
        if (data.points-25>0)
            data.points -= 25;
    }
}
