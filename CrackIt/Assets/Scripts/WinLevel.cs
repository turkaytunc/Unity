using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLevel : MonoBehaviour
{
    [SerializeField] private int blockCount;
    [SerializeField] private GameObject[] gameObjects;
    private int canvasObjects;


    private void Awake()
    {
        canvasObjects = FindObjectsOfType<WinLevel>().Length;

        if(canvasObjects > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    void Update()
    {
        blockCount = FindObjectsOfType<Block>().Length;
        string currentScene = SceneManager.GetActiveScene().name;
        if (blockCount <= 0 && currentScene == "Scene001")
        {
            gameObjects = new GameObject[2];
            gameObjects[0] = GameObject.FindGameObjectWithTag("Score").transform.Find("NextLevelButton").gameObject;
            gameObjects[1] = GameObject.FindGameObjectWithTag("Score").transform.Find("WinLevelText").gameObject;
            Time.timeScale = 0f;
            gameObjects[0].SetActive(true);
            gameObjects[1].SetActive(true);
        }
    }
}
