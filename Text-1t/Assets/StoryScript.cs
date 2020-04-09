using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class StoryScript : MonoBehaviour
{
    [SerializeField] Text textComponent;


    void Start()
    {
        textComponent.text = "Start function initial text!";
    }

    // Update is called once per frame
    private void Update()
    {

    }
}
