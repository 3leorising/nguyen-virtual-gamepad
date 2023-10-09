using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 
using TMPro; 

public class Vsticks : MonoBehaviour
{
    public TextMeshProUGUI Output; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Output.text = ""; 
        Gamepad gpad = Gamepad.current; 
        if (gpad == null)
        {
            Output.text = "No GamePad";
            return; 
        }

        string result = "Gpad";

        result = result + "\nL: " + gpad.leftStick.ReadValue().ToString();

        result = result + "\nR: " + gpad.rightStick.ReadValue().ToString();

        result = result + "\nE: " + gpad.buttonEast.isPressed.ToString();

        result = result + "\nW: " + gpad.buttonWest.isPressed.ToString();



        Output.text = result; 
    }
}
