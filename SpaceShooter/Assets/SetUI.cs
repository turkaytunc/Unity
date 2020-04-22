using TMPro;
using UnityEngine;

public class SetUI : MonoBehaviour
{
    private GameManager gameManager;

    private TextMeshProUGUI scoreText;
    private TextMeshProUGUI playerHealthText;



    private void Awake()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void Start()
    {
        
        scoreText = transform.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        if (gameManager.IsGameOver == false)
        {
            playerHealthText = transform.Find("PlayerHealthText").GetComponent<TextMeshProUGUI>();
            playerHealthText.text = gameManager.GetPlayerHealth().ToString();
        }

        scoreText.text = gameManager.GetScore().ToString();

    }

    private void Update()
    {
        scoreText.text = gameManager.GetScore().ToString();
        if (gameManager.IsGameOver == false)
        {
            playerHealthText.text = gameManager.GetPlayerHealth().ToString();
        }
    }

}
