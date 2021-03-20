using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    public GameObject color;


    public void ChangeColor()
    {
        Color[] colors =
        {
            new Color32(152,151,152,100),
            new Color32(0,255,127,100),
            new Color32(255,127,80,100),
            new Color32(255,20,147,100),
            new Color32(255,64,64,100),
            new Color32(255,165,79,100),
            new Color32(138,43,226,100),
            new Color32(173,255,47,100),
        };


        if (Input.GetKeyDown("space"))
        {
            color.GetComponent<Image>().color = colors[Random.Range(0, colors.Length)];
        }
    }

    void Update()
    {
        ChangeColor();
    }
}