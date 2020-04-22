using TMPro;
using UnityEngine;

public class SetUI : MonoBehaviour
{
    [SerializeField] private GameObject gameManagerObject;
    private GameManager gameManager;

    private TextMeshProUGUI scoreText;
    private TextMeshProUGUI playerHealthText;

    private void Start()
    {
        gameManager = gameManagerObject.GetComponent<GameManager>();
        scoreText = transform.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        playerHealthText = transform.Find("PlayerHealthText").GetComponent<TextMeshProUGUI>();

        scoreText.text = "0";
        playerHealthText.text = gameManager.GetPlayerHealth().ToString();

    }

}
