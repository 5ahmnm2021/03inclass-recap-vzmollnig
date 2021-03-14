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

    public float if1Float;
    public float if2Float;

    public void Addition()
    {
        try
        {
            if1Float = float.Parse(if1.text);
            if1.image.color = weiss;
            message.text = "";
        }
        catch (System.Exception)
        {
            message.text = "Geben Sie eine gültige Zahl ein";
            if1.image.color = rot;
        }

        try
        {
            if2Float = float.Parse(if2.text);
            if2.image.color = weiss;
        }
        catch (System.Exception)
        {
            message.text = "Geben Sie eine gültige Zahl ein";
            if2.image.color = rot;
        }

        sum.text = (if1Float + if2Float).ToString();
        Debug.Log("Die Addition ergibt: " + sum.text);
    }
}