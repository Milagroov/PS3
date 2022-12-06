using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    public GameObject Panel;
    public Animator transition;
    public float transitionTime = 1f;

    void update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Anim();
        }
    }

    public void OpenPanel()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);
            Debug.Log(isActive);
        }
    }

    public IEnumerator Anim()
    {
        transition.SetTrigger("TransitionMenu");

        yield return new WaitForSeconds(transitionTime);

        OpenPanel();
    }
}
