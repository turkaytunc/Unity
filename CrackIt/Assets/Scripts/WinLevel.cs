using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLevel : MonoBehaviour
{
    [SerializeField] private int blockCount;
    [SerializeField] private GameObject[] gameObjects;

    // Update is called once per frame
    void Update()
    {
        blockCount = FindObjectsOfType<Block>().Length;
        if (blockCount <= 0)
        {
            Time.timeScale = 0f;
            for(int i = 0; i < gameObjects.Length; i++)
            {
                gameObjects[i].SetActive(true);
            }
        }
    }
}
