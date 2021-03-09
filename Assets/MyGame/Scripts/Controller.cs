using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
   public void LoadColorScene()
    {
        SceneManager.LoadScene("01ColorScene");
    }

    public void LoadNumberScene()
    {
        SceneManager.LoadScene("02NumberScene");
    }

    public void LoadWelcomeScene()
    {
        SceneManager.LoadScene("00WelcomeScene");
    }
}
