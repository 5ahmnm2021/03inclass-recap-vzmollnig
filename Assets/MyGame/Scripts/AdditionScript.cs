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

    public Color rot = Color.red;
    public Color weiss = Color.white;

    float if1Float;
    float if2Float;
    
    bool num1 = true;
    bool num2 = true;

    public void Addition()
    {
        try
        {
            if1Float = float.Parse(if1.text);
            if1.image.color = weiss;
            message.text = "";
            num1 = true;
        }
        
        catch (System.Exception)
        {
            message.text = "Geben Sie eine gültige Zahl ein! ";
            if1.image.color = rot;
            num1 = false;
        }

        try
        {
            if2Float = float.Parse(if2.text);
            if2.image.color = weiss;
            message.text = "";
            num2 = true;
        }
        
        catch (System.Exception)
        {
            message.text = "Geben Sie eine gültige Zahl ein";
            if2.image.color = rot;
            num2 = false;
        }

    if(num1 == true && num2 == true){
        sum.text = (if1Float + if2Float).ToString();
        Debug.Log("Das Ergebnis ist " + sum.text);
      }  
        else {
        sum.text = "/";
    
    }
}}