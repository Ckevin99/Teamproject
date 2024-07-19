using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goalpanel : MonoBehaviour

{
    // Start is called before the first frame update
    public Button button;
    public Button buttondel;
    public Data maindata;
    public GameObject parentObject;

    public Transform goalListParent;
    public GameObject goalPrefab;


    void Start()
    {
        button.onClick.AddListener(displaygoals);
 
        Debug.Log("started");


    }

    // Update is called once per frame

public void displaygoals()
    {
                foreach (var goalData in maindata.goals)
        {
            GameObject goal = Instantiate(goalPrefab, goalListParent);
            Toggle toggle = goal.GetComponentInChildren<Toggle>();
            ToggleGoal(goalData);
            Text goaldetail = goal.GetComponentInChildren<Text>();

            goaldetail.text = $"Goal Name - {goalData.goal_name} | Points - {goalData.goal_points}";
            toggle.onValueChanged.AddListener(delegate { ToggleGoal(goalData); });
            
        }
    }
    public void DestroyAllChildren(Transform parent)
    {
        foreach (Transform child in parent)
        {
            Destroy(child.gameObject);
        }
    }

        
    void ToggleGoal(Goal goalData)
    {
        goalData.isCompleted = !goalData.isCompleted;
        // Add any additional logic for when a goal is toggled
    }
    


}
