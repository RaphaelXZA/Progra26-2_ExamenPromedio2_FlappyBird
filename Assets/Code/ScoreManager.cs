using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }
    public int Score { get; private set; }
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        FindTextGameObject();
    }

    public void AddScore(int pointsAdded)
    {
        Score += pointsAdded;
        UpdateScoreText();
    }

    public void ResetScore()
    {
        FindTextGameObject();
        Score = 0;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = $"Score: {Score}";
    }

    private void FindTextGameObject()
    {
        if (scoreText == null)
        {
            GameObject scoreObject = GameObject.FindGameObjectWithTag("ScoreText");
            if (scoreObject != null)
            {
                scoreText = scoreObject.GetComponent<TextMeshProUGUI>();
            }
        }
    }

    
}
