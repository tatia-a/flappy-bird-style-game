using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    private int score = 0;
    public int Score { get => score; }
    public void AddScore(int scoreCount)
    {
        score += scoreCount; 
    }
}
