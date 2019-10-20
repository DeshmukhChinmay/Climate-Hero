using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementScript : MonoBehaviour
{
    public Text forestQuest, desertQuest;
    public Image forestQuestImage, desertQuestImage;
    public Sprite forestQuestComplete, desertQuestComplete;
    // Start is called before the first frame update
    void Start()
    {
        if (ForestQuestScript.checkStatus() == true)
        {
            forestQuest.text = "Forest Quest Complete";
            forestQuestImage.sprite = forestQuestComplete;
        }
        if (DesertQuestScript.checkStatus() == true)
        {
            desertQuest.text = "Desert Quest Complete";
            desertQuestImage.sprite = desertQuestComplete;
        }
    }

}