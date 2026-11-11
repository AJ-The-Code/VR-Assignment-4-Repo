using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class AnimateHand : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    public Animator handAnimator;
    public InputActionProperty gripAnimationAction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float triggerValue = pinchAnimationAction.action.ReadValue<float>();  //Reads the amount of times the button is pressed 
       handAnimator.SetFloat("Trigger", triggerValue); //This send a value (0/1) to the animator. Basically on/off when trigger happens.

        float gripTrigValue = gripAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripTrigValue);
    }
}
