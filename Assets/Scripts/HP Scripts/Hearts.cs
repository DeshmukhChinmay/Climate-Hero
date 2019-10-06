using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hearts : MonoBehaviour
{
    public int health;
    public int numberOfHearts;
    public Image[] hearts;
    public Sprite heart;
    void Update()
    {
        for (int i=0; i < numberOfHearts; i++) {
            if (i < numberOfHearts)
            {
                hearts[i].enabled = true;
            }
            else {
                hearts[i].enabled = false;
            }
        }
  
    }
}
