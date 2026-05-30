using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject creditsPanel;

    public void StartGame()
    {
        SceneManager.LoadScene(1);

    }
    
    public void ShowCredits()
    {
        if (creditsPanel != null)
        {
            if (!creditsPanel.activeSelf)
            {
                creditsPanel.SetActive(true);
            }
            else
            {
                creditsPanel.SetActive(false);
            }
        }    
    }
}
