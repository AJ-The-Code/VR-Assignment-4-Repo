using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateTeleportationRay : MonoBehaviour
{
    public GameObject rightHandTransportation;
    public GameObject leftHandTransportation;

    public InputActionProperty leftActive;
    public InputActionProperty rightActive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leftHandTransportation.SetActive(leftActive.action.ReadValue<float>() > .1f); //Takes the input from the controller and then turns the ray on if controller button has enough pressure on it.
        rightHandTransportation.SetActive(rightActive.action.ReadValue<float>() > .1f);

    }
}
