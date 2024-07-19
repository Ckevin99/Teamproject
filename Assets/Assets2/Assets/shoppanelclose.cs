using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shoppanelclose : MonoBehaviour

{
    // Start is called before the first frame update
    public GameObject shop_panel;
    public Button button;
    void Start()
    {
        button.onClick.AddListener(SetPanelActive);
        Debug.Log("started");
    }

    // Update is called once per frame
public void SetPanelActive()
{
    Debug.Log("Hi");
    shop_panel.SetActive(false);
}
}
