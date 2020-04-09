using UnityEngine.UI;
using UnityEngine;

public class StoryScript : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;
    void Start()
    {
        textComponent.text = startingState.GetStateStory();
    }
}
