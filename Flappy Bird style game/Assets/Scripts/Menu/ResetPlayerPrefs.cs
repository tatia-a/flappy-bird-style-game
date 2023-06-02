using UnityEngine;

public class ResetPlayerPrefs : MonoBehaviour
{
    private void Awake()
    {
        PlayerPrefs.DeleteAll();
    }
}
