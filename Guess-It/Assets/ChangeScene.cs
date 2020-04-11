using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public void ChangeSceneFunction()
    {
        SceneManager.LoadScene("Scene001");
    }
}
