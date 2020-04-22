using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetUI : MonoBehaviour
{
    private GameManager gameManager;

    private TextMeshProUGUI scoreText;
    private TextMeshProUGUI playerHealthText;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        scoreText = transform.Find("ScoreText").GetComponent<TextMeshProUGUI>();

        scoreText.text = gameManager.GetScore().ToString();


        if (gameManager.IsGameOver == false)
        {
            Debug.Log("player text loaded");
            playerHealthText = transform.Find("PlayerHealthText").GetComponent<TextMeshProUGUI>();
            playerHealthText.text = gameManager.GetPlayerHealth().ToString();
        }
    }

    private void Update()
    {
        
        scoreText.text = gameManager.GetScore().ToString();
        if (gameManager.IsGameOver == false && SceneManager.GetActiveScene().name != "MainMenu")
        {
            playerHealthText.text = gameManager.GetPlayerHealth().ToString();
        }
    }



}
