using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI finalScoreText;

    private void Start()
    {
        finalScoreText.text = $"Final Score: {ScoreManager.Instance.Score}";
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
