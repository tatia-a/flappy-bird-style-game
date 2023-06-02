using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public void EasyLevel()
    {
        SceneManager.LoadScene("EasyLevel");
    }
    public void MediumLevel()
    {
        SceneManager.LoadScene("MediumLevel");
    }
    public void HardLevel()
    {
        SceneManager.LoadScene("HardLevel");
    }
}
