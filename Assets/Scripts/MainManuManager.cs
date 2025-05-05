using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManuManager : MonoBehaviour
{
    public void OnStartClicked()
    {
        SceneManager.LoadScene(1);
    }

    public void OnExitClicked()
    {
        Application.Quit();
    }
}
