using UnityEngine;

public class ButtonAnimation : MonoBehaviour
{
    public Animator animator;

    public void PlayAnimation()
    {
        animator.Play("Play");
    }
}