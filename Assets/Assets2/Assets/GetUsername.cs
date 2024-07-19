using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetUsername : MonoBehaviour
{
    // Start is called before the first frame update

    public Data scriptdata;
    public TMP_Text txttext;

    void Start()
    {
        txttext.text = $"User: {scriptdata.user_name}" ;
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(scriptdata.user_name);
        
        
    }
}
