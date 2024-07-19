using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displaylistgoals : MonoBehaviour
{
    // Start is called before the first frame update
    public Data_user maindata;
    public GameObject parentObject;
    void Start()
    {
        displaygoals();
        
    }

    // Update is called once per frame
    void displaygoals()
    {
        foreach (var i in maindata.goals){
            GameObject goal = new GameObject("GoalObject");
            goal.tag = "Goal";
   

   
            TextMesh textComponent = goal.AddComponent<TextMesh>();
            textComponent.text = "Goal"; 
            textComponent.fontSize = 100; 
            textComponent.color = Color.white; 
            textComponent.transform.SetParent(parentObject.transform, false);
            goal.transform.SetParent(parentObject.transform, false);

        }
        
    }
}
