using UnityEngine.UI;
using UnityEngine;

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
}
