using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    private PlayerScore playerScore;
    [SerializeField] TextMeshProUGUI scoreText;

    void Start()
    {
        playerScore = FindObjectOfType<PlayerScore>();
    }

    void Update()
    {
        scoreText.text = playerScore.Score.ToString();
    }
}
