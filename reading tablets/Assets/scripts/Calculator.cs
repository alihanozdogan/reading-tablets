using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Calculator : MonoBehaviour {
 [SerializeField]//or use public in next line
 Text Result_Display;
 string InputString;
 int[] arg=new int[2] {0,0};
 int i=0;
 string operation;
 int answer,x;
 bool nextRun=true;

 public void ButtonPressed(){
  if (nextRun) {
   InputString = "";
   nextRun = false;
  }
  //Debug.Log (EventSystem.current.currentSelectedGameObject.name); 
  string ButtValue = EventSystem.current.currentSelectedGameObject.name;
  InputString += ButtValue;
  Result_Display.text = InputString;

  if (int.TryParse (ButtValue, out x)) {
   arg [i] = (arg [i] * 10) + int.Parse (ButtValue);
   //Result_Display.text = arg [i].ToString ();
  } 
  else {
   if (ButtValue != "=") {
    operation = ButtValue;
    i++;
   } else {
    switch (operation) {
     case "+":
     answer = arg [0] + arg [1];
     break;
    case "-":
     answer = arg [0] - arg [1];
     break;
    case "*":
     answer = arg [0] * arg [1];
     break;
    case "/":
     answer = arg [0] / arg [1];
     break;
    }

    Result_Display.text = answer.ToString();
    arg [0] = 0;
    arg [1] = 0;
    i = 0;
    nextRun = true;
   }
  }

 }

}