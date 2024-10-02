using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculationScript : MonoBehaviour
{
    [SerializeField] private InputField firstInputField;
    [SerializeField] private InputField secondInputField;

    [SerializeField] private InputField answerInputField;

    public void Add()
    {
        double firstNumber = double.Parse(firstInputField.text);
        double secondNumber = double.Parse(secondInputField.text);
        double answer = firstNumber + secondNumber;
        answerInputField.text = answer.ToString();
    }

    public void Subtract()
    {
        double firstNumber = double.Parse(firstInputField.text);
        double secondNumber = double.Parse(secondInputField.text);
        double answer = firstNumber - secondNumber;
        answerInputField.text = answer.ToString();
    }

    public void Multiply()
    {
        double firstNumber = double.Parse(firstInputField.text);
        double secondNumber = double.Parse(secondInputField.text);
        double answer = firstNumber * secondNumber;
        answerInputField.text = answer.ToString();
    }

    public void Divide()
    {
        double firstNumber = double.Parse(firstInputField.text);
        double secondNumber = double.Parse(secondInputField.text);
        if (secondNumber != 0){
            double answer = firstNumber / secondNumber;
            answerInputField.text = answer.ToString();
        }
        else {
            answerInputField.text = "Error";
        }
    }

    public void Clear()
    {
        firstInputField.text = "";
        secondInputField.text = "";
        answerInputField.text = "";
    }
}
