using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(10,14)][SerializeField] string storyText;
    [SerializeField] State[] nextStates;
    [SerializeField] Boolean isCrowbarNeeded = false;
    [SerializeField] Boolean hasCrowbar = false;
    [SerializeField] Boolean isGameover = false;
    
    public string GetStateStory() {
        return storyText;
    }

    public State[] GetNextStates() {
        return nextStates;
    }

    public Boolean GetHasCrowbar() {
        return hasCrowbar;
    }

    public Boolean GetIsNeededCrowbar() {
        return isCrowbarNeeded;
    }

    public Boolean GetIsGameover() {
        return isGameover;
    }
}
