using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScreenPoints : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text Points_txt;
    public Data data;


    void Start()
    {
        Points_txt.text = $"Points :{data.points}";    
    }
    void Update(){

        Points_txt.text = $"Points :{data.points}";   
    }
    // Update is called once per frame
}
