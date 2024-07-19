using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System;

public class AddGoal : MonoBehaviour
{

    public TMP_InputField input;

    public TMP_InputField input_points;

    public Button button;

    public Button button_delete;

    public Data data;
    public GameObject parentObject;

    public Transform goalListParent;
    public GameObject goalPrefab;

    


    // Start is called before the first frame update
    void Start()
    {
        GameObject alldata = new GameObject();
        alldata.AddComponent<Data>();
        
        button.onClick.AddListener(OnButtonClick);
        DontDestroyOnLoad(alldata);
    }

    // Update is called once per frame
    public void OnButtonClick()
    {
      // var new_goal = new Goal(input.text, 100);
      // text_goal.text = $"Goal {new_goal.goal_name} added" ;



    // Create a game object and add this to the list of goals- when the user makes the goal name & points value
      GameObject goal = new GameObject();
      goal.AddComponent<Goal>();
      var goaldata = goal.GetComponent<Goal>();


      goaldata.goal_name = input.text;
      goaldata.goal_points =  Int32.Parse(input_points.text);




    
    data.AddGoal(goaldata);
    DestroyAllChildren(goalListParent);
    displaygoals();

    }

    // Makes a copy for each iteration and displays it
    public void displaygoals()
    {

                foreach (var goalData in data.goals)
        {
            GameObject goal = Instantiate(goalPrefab, goalListParent);
            Toggle toggle = goal.GetComponentInChildren<Toggle>();
            Text goaldetail = goal.GetComponentInChildren<Text>();
            Button buttondel = goal.GetComponentInChildren<Button>();
            buttondel.onClick.AddListener(delegate { delete(goalData); });
            toggle.isOn = goalData.isCompleted;
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
        if (goalData.isCompleted){
          data.points += goalData.goal_points;
        }
        else{
          data.points -= goalData.goal_points;
        }
        // Add any additional logic for when a goal is toggled
    }
        void delete(Goal goalData)
    {
        data.goals.Remove(goalData);
        DestroyAllChildren(goalListParent);
        displaygoals();
        // Add any additional logic for when a goal is toggled
    }
}
