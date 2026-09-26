using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // This line enables use of uGUI classes like Text.        // a
using TMPro; 

  public class ScoreCounter : MonoBehaviour {
     [Header("Dynamic")]                                                          // b
     public int score = 0;
 
     private TMP_Text uiText;

      void Start()
         {
            uiText = GetComponent<TMP_Text>();
            score = 0;
         }
 
      void Update() {
         uiText.text = score.ToString( "#,0" ); // This 0 is a zero!              // e
      }
  }