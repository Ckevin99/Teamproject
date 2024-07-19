using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shoppanelclosen : MonoBehaviour

{
    // reference object data
    public GameObject shop_panel;
    public Button button;
    void Start()
    {
        button.onClick.AddListener(SetPanelActive);
        Debug.Log("started");
    }

    // Close panel on click
public void SetPanelActive()
{
    Debug.Log("Hi");
    shop_panel.SetActive(false);
}
}
