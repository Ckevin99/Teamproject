using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Data : MonoBehaviour
{
    // Start is called before the first frame update
    public int points = 0;
    public string user_name = "User";

    public List<Goal> goals = new List<Goal>();


    public void AddGoal(Goal goal){
        goals.Add(goal);
        
    }
    public string display(){
        string goalsname = "";
        foreach(var x in goals){
            goalsname = goalsname + x.goal_name;
        }
        return goalsname;
        
    }




}

public class Goal : MonoBehaviour{

    public string goal_name;
    public int goal_points;

    public bool isCompleted= false;

    public Goal(string goal, int points)
    {
    goal_points = points;
    
    goal_name = goal;
    }

}


