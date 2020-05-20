using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoremanager : MonoBehaviour
{  public int score;
   public Text scoreDisplay;
  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.CompareTag("Obstacle")){//inctrase score of 1
      score++;
      Debug.Log(score);
    }
     

     
      
  }
  private void Update()
{scoreDisplay.text = score.ToString();

   } 
  }
