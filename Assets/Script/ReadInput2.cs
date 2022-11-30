using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReadInput2 : MonoBehaviour
{
    private string input;
    public string sceneWin;
    public string sceneLose;

    public void ReadStringInput(string n)
    {
        input = n;
        Debug.Log(input);
        if (input == "60")
        {
            SceneManager.LoadScene(sceneWin);
        }
        else
        {
            SceneManager.LoadScene(sceneLose);
        }
    }

}
