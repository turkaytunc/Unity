using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    [SerializeField] private string nextScene;
    public void ChangeSceneFunction()
    {
        SceneManager.LoadScene(nextScene);
    }
}
