using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Block : MonoBehaviour
{
    [SerializeField] private GameObject tmPro;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        tmPro.GetComponent<Score>().currentScore += 1;
        Destroy(gameObject);
    }
}
