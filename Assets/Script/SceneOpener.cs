using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneOpener : MonoBehaviour
{
    public string sceneToLoad;
    public Animator transition;
    public float transitionTime = 1f;

    void update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Anim();
        }
    }

    public void OpenScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    IEnumerator Anim()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        OpenScene();
    }

}
