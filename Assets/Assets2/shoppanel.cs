using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shoppanel : MonoBehaviour

{
    // refernce objects
    public GameObject shop_panel;
    public Button button;
    void Start()
    {
        button.onClick.AddListener(SetPanelActive);
        Debug.Log("Hi");
    }

    // Open panel
public void SetPanelActive()
{
    Debug.Log("Hi");
    shop_panel.SetActive(true);
}
}
