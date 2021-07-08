using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]


public class State : ScriptableObject
{
    // Start is called before the first frame update
    [TextArea(14,10)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;
    public string getStateStory()
    {
        return storyText;
    }
    public State[] getNextStates()
    {
        return nextStates;
    }
}

