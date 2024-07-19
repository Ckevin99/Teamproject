using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class changescene : MonoBehaviour
{
    // Start is called before the first frame update

    public Button button;
    void Start()
    {
         button.onClick.AddListener(LoadMyScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadMyScene()
    {
        SceneManager.LoadScene("ss"); // Replace with your scene name
    }
}

