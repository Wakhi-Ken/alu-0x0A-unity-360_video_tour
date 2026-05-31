using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class SceneLoader : MonoBehaviour
{
    [Header("Input Actions")]
    public InputActionProperty backButton;

    private void OnEnable()
    {
        backButton.action?.Enable();
    }

    private void OnDisable()
    {
        backButton.action?.Disable();
    }

    private void Update()
    {
        // B button (Right Controller Secondary Button)
        if (backButton.action != null && backButton.action.WasPressedThisFrame())
        {
            LoadStartMenu();
        }
    }

    public void Load360Scene()
    {
        SceneManager.LoadScene("360VideoTour");
    }

    public void LoadCustomScene()
    {
        SceneManager.LoadScene("Custom");
    }

    public void LoadStartMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}