using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goalpanelclose : MonoBehaviour

{
    // reference object data
    public GameObject goal_panel;
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
    goal_panel.SetActive(false);
}
}
