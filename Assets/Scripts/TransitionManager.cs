using UnityEngine;
using System.Collections;

public class TransitionManager : MonoBehaviour
{
    public Animator fadeAnimator;
    public GameObject[] spheres;

    private int currentSphere = 0;

    public void SwitchTo(int targetSphere)
    {
        if (targetSphere == currentSphere)
            return;

        StartCoroutine(Transition(targetSphere));
    }

    IEnumerator Transition(int targetSphere)
    {
        fadeAnimator.SetTrigger("FadeIn");

        yield return new WaitForSeconds(0.75f);

        spheres[currentSphere].SetActive(false);
        spheres[targetSphere].SetActive(true);

        currentSphere = targetSphere;

        fadeAnimator.SetTrigger("FadeOut");
    }
}