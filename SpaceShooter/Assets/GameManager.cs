using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private float playerHealth = 100;
    private float score = 0;



    public void GameOver()
    {
        StartCoroutine(LoadGameOverScene());
    }

    public void SetPlayerHealth(float playerHealth)
    {
        if(playerHealth >= 0)
        {
            this.playerHealth = playerHealth;

        }
        else
        {
            this.playerHealth = 0;
        }
    }

    public float GetPlayerHealth()
    {
        return this.playerHealth;
    }


    public void SetScore(float score)
    {
        this.score += score;
    }

    public float GetScore()
    {
        return this.score;
    }



    private IEnumerator LoadGameOverScene()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("GameOver");

    }


}
