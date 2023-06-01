using UnityEngine;

public class TubeGap : MonoBehaviour
{
    private PlayerScore playerScore;
    private bool canAddScore = true;

    private void Awake()
    {
        playerScore = FindObjectOfType<PlayerScore>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && canAddScore)
        {
            playerScore.AddScore(1);
            canAddScore = false;
        }
    }
}
