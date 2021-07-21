using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State currState;
    Boolean gotCrowbar = false;
    // Start is called before the first frame update
    void Start() {
        currState = startingState;
        textComponent.text = currState.GetStateStory();
    }

    // Update is called once per frame
    void Update() {
        ManageState();
    }

    private void ManageState() {
        var nextStates = currState.GetNextStates();

        if (currState.GetIsGameover()) {
            gotCrowbar = false;
        }

        for(int i = 0; i < nextStates.Length; i++) {
            if(Input.GetKeyDown(KeyCode.Alpha1 + i)) {
                // Hacky way to "add crowbar to inventory"
                if (currState.GetHasCrowbar()) {
                    gotCrowbar = true;
                }
                // Hacky way to "check if crowbar is in inventory"
                if (currState.GetIsNeededCrowbar() && !gotCrowbar) {
                    currState = nextStates[nextStates.Length - 1];
                } else {
                    currState = nextStates[i];
                }
            }
        }
        textComponent.text = currState.GetStateStory();
    }
}