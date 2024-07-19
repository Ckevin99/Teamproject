using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Data_user : MonoBehaviour
{
    // Create initial data
    public int points = 0;
    public string user_name = "User";

    public List<User_Goal> goals = new List<User_Goal>();

    public void AddGoal(User_Goal goal){
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
// Goal object
public class User_Goal : MonoBehaviour{

    public string goal_name;
    public int goal_points;

    public User_Goal(string goal, int points)
    {
    goal_points = points;
    
    goal_name = goal;
    }

}


