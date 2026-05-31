using UnityEngine;
using System.Collections;

public class Hover : MonoBehaviour
{
    public GameObject panel;

    private Coroutine hideCoroutine;

    
    public void ShowPanel()
    {
        // Stop previous timer if hovering again
        if (hideCoroutine != null)
        {
            StopCoroutine(hideCoroutine);
        }

        panel.SetActive(true);

        // Start countdown to hide
        hideCoroutine = StartCoroutine(HideAfterSeconds());
    }

    IEnumerator HideAfterSeconds()
    {
        yield return new WaitForSeconds(3f);

        panel.SetActive(false);
    }
}