using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    TextMeshProUGUI textMesh;
    public int currentScore = 0;
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.text = "Score: " + currentScore.ToString();
    }
}
