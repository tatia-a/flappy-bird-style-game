using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab;

    private OnOffButton button;
    private AudioSource musicPlayer;

    void Start()
    {
        button = GetComponent<OnOffButton>();

        musicPlayer = playerPrefab.GetComponent<AudioSource>();

        musicPlayer.enabled = button.IsActive;
    }
    private void Update()
    {
        musicPlayer.enabled = button.IsActive;
    }
}
