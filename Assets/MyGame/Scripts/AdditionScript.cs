using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdditionScript : MonoBehaviour
{
    public InputField if1;
    public InputField if2;
    public Text sum;
    public Text message;

    float if1Float;
    float if2Float;
    
    bool num1 = true;
    bool num2 = true;

    public void Addition()
    {
        try
        {
            if1Float = float.Parse(if1.text);
            message.text = "";
            num1 = true;
            if1.image.color = Color.white;
        }
        
        catch (System.Exception)
        {
            if1.image.color = Color.red;
            num1 = false;
        }


        try
        {
            if2Float = float.Parse(if2.text);
            message.text = "";
            num2 = true;
            if2.image.color = Color.white;
        }
        
        catch (System.Exception)
        {
            if2.image.color = Color.red;
            num2 = false;
        }
        

    if(num1 == true && num2 == true) {
        sum.text = (if1Float + if2Float).ToString();
        Debug.Log("Das Ergebnis ist " + sum.text);
         }  

        else {
        sum.text = "/";
        message.text = "Bitte geben Sie eine gültige Zahl ein!";
        }
   
    }
}