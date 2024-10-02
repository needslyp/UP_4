using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompareTwoNumbers : MonoBehaviour
{
   [SerializeField] private InputField firstInputField;
   [SerializeField] private InputField secondInputField;
   [SerializeField] private Text resultText;

   public void Compare()
   {
       double firstNumber = double.Parse(firstInputField.text);
       double secondNumber = double.Parse(secondInputField.text);
       
       if (firstNumber > secondNumber)
       {
           resultText.text = ">";
       }
       else if (firstNumber < secondNumber)
       {
           resultText.text = "<";
       }
       else
       {
           resultText.text = "=";
       }
   }

   public void Clear()
   {
       firstInputField.text = "";
       secondInputField.text = "";
       resultText.text = "";
   }
   
}
