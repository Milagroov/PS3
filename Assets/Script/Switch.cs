using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using ScoredProductions;

public class Switch : MonoBehaviour
{
    [SerializeField] private float DelayAnim;
    [SerializeField] private float DelayScene;
    [SerializeField] private string sceneToLoad;
    public Animator transition;

    private float timeElapsed;

    private void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > DelayAnim)
        {
            transition.SetTrigger("start");
        }

        if (timeElapsed > DelayScene)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }

}
