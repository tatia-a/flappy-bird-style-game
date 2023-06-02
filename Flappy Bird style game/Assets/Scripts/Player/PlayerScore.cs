using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    private int score = 0;
    public int Score { get => score; }

    private AudioSource audioSource;
    [SerializeField] AudioClip addScoreSound;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void AddScore(int scoreCount)
    {
        score += scoreCount;
        audioSource.clip = addScoreSound;
        audioSource.Play();
    }
}
