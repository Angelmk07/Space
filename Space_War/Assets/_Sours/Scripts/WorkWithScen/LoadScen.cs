using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScen : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
