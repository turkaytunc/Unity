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

        for (int i = 0; i < nextState.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                state = nextState[i];
            }
        }
        textComponent.text = state.GetStateStory();
    }
}
