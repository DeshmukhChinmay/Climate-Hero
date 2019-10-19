using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class ForestQuestScript : MonoBehaviour
{
    public static int totalObjectives = 0;
    public static int completedObjectives = 0;
    // Start is called before the first frame update
    public static void completeObjective(){
        completedObjectives += 1;
        Debug.Log(completedObjectives);
    }

    public static bool checkStatus(){
        if(totalObjectives == completedObjectives){
            return true;
        }
        return false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
