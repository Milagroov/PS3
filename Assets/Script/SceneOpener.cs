using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneOpener : MonoBehaviour
{
    public string sceneToLoad;

    public void OpenScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
