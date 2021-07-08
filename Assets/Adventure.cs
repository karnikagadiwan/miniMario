using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Adventure : MonoBehaviour
{
    [SerializeField]Text textComponent;
    [SerializeField] State startingState;
    // Start is called before the first frame update
    State state;
    void Start()
    {
        state =startingState;
        textComponent.text = state.getStateStory();       
    }

    // Update is called once per frame
    void Update()
    {
        manageState();
        
    }

    private void manageState()
    {
        var nextStates = state.getNextStates();
        for(int i=0;i<nextStates.Length;i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1+i))
            {
                state = nextStates[i];
            }
        }
            /*
       
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            
        state = nextStates[2];
        }
            */
        textComponent.text = state.getStateStory();
    }
}
