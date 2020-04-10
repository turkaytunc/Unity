using UnityEngine.UI;
using UnityEngine;
using System;

public class StoryScript : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    private State state;
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    private void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        State[] nextState = state.GetNextStates();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextState[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextState[1];
        } 

        textComponent.text = state.GetStateStory();
    }
}
