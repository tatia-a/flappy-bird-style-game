using UnityEngine;

public class MusicController : MonoBehaviour
{
    private OnOffButton button;
    private AudioSource musicPlayer;

    void Start()
    {
        button = GetComponent<OnOffButton>();

        musicPlayer = FindObjectOfType<MusicPlayer>().gameObject.GetComponent<AudioSource>();

        musicPlayer.enabled = button.IsActive;
    }

    private void Update()
    {
        musicPlayer.enabled = button.IsActive;
    }

}
