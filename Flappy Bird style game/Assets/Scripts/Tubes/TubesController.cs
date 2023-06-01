using System;
using UnityEngine;

public class TubesController : MonoBehaviour
{
    // Если игрок умрет, выключатся трубы
    PlayerController playerController;
    private TubesSpawner spawner;
    private bool isGameStopped = false;

    private void Awake()
    {
        playerController = FindObjectOfType<PlayerController>();
        spawner = FindObjectOfType<TubesSpawner>();
    }
    void Update()
    {
        // снять спавн труб с паузы
        bool isPaused = playerController.PlayerState == PlayerController.States.OnPause;
        if (!isPaused) spawner.enabled = true;

        // остановить трубы при смерти игрока
        bool isDead = playerController.PlayerState == PlayerController.States.Died;
        if (isDead && !isGameStopped)
        {
            StopTubes();
        }

    }
    private void StopTubes()
    {
        isGameStopped = true;
        spawner.StopSpawn();
        var tubesOnScene = FindObjectsOfType<Tube>();
        foreach (var tube in tubesOnScene)
        {
            tube.enabled = false;
        }
        
    }
}
