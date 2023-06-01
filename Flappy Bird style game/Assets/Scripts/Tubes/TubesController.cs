using System;
using UnityEngine;

public class TubesController : MonoBehaviour
{
    // ���� ����� �����, ���������� �����
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
        // ����� ����� ���� � �����
        bool isPaused = playerController.PlayerState == PlayerController.States.OnPause;
        if (!isPaused) spawner.enabled = true;

        // ���������� ����� ��� ������ ������
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
