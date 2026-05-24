using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject currentSphere;
    public GameObject nextSphere;

    public void SwitchRooms()
    {
        currentSphere.SetActive(false);
        nextSphere.SetActive(true);
    }
}