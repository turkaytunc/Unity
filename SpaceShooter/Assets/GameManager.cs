using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private float playerHealth = 100;

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



    private IEnumerator LoadGameOverScene()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("GameOver");

    }


}
