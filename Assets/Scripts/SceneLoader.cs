using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void Load360Scene()
    {
        SceneManager.LoadScene("360VideoTour");
    }

    public void LoadCustomScene()
    {
        SceneManager.LoadScene("Custom");
    }
}