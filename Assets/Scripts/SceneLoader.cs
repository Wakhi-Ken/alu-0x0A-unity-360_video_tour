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
        // B button (left Controller Secondary Button)
        if (backButton.action != null && backButton.action.WasPressedThisFrame())
        {
            LoadStartMenu();
        }
    }

    public void Load360Scene()
    {
        SceneManager.LoadScene("IntranetTourScene");
    }

    public void LoadCustomScene()
    {
        SceneManager.LoadScene("CustomCampusTourScene");
    }

    public void LoadStartMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}