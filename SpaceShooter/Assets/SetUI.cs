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
        playerHealthText = transform.Find("PlayerHealthText").GetComponent<TextMeshProUGUI>();

        scoreText.text = gameManager.GetScore().ToString();
        playerHealthText.text = gameManager.GetPlayerHealth().ToString();

    }

    private void Update()
    {
        scoreText.text = gameManager.GetScore().ToString();
        playerHealthText.text = gameManager.GetPlayerHealth().ToString();
    }

}
