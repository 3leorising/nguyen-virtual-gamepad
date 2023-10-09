using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// Player Number
// #0 : Key Board and Mouse input
// #1 : Gamepad Input 

// Multiple Gamepads requires much more code! 


public class InputPoller : MonoBehaviour
{
    public static InputPoller reference; 

    void Awake()
    {
        if (reference != null)
        {
            // we have another instance of this system. 
            // the Solution here is to delete the other version 
            Debug.LogWarning("Found another instance of InputPoller on " + reference.name); 
            Destroy(reference); 
        }
        reference = this;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public InputData GetInput(int PlayerNumber)
    {
        if (PlayerNumber == 0) { return GetInputP0(); }
        if (PlayerNumber == 1) { return GetInputP1(); }

        // Defaut return 
        return InputData.CleanDataStruct();

    }

    // this is the Keyboard and Mouse Info
    public InputData GetInputP0()
    {
        InputData input = InputData.CleanDataStruct();

        Keyboard kb = Keyboard.current; 
        // Verifiy we have Keyboard data 
        if (kb != null)
        {
            input.buttonNorth = kb.wKey.wasPressedThisFrame;
            input.buttonSouth = kb.sKey.wasReleasedThisFrame;
            input.buttonEast = kb.aKey.isPressed;
            input.buttonEast = kb.dKey.isPressed;

        }


        return input;
    }

    // This is the First GamePad Connected Info
    public InputData GetInputP1()
    {
        InputData input = InputData.CleanDataStruct();

        Gamepad gpad = Gamepad.current;
        // verify we have gamepad data
        if (gpad != null)
        {
            input.leftStick = gpad.leftStick.ReadValue();
            input.rightStick = gpad.rightStick.ReadValue();
            input.dpad = gpad.dpad.ReadValue();
            input.leftStickButton = gpad.leftStickButton.wasPressedThisFrame;
            input.rightStickButton = gpad.rightStickButton.wasPressedThisFrame;
            input.leftTrigger = gpad.leftTrigger.ReadValue();
            input.rightTrigger = gpad.rightTrigger.ReadValue();
            input.leftShoulder = gpad.leftShoulder.wasPressedThisFrame;
            input.rightShoulder = gpad.rightShoulder.wasPressedThisFrame;
            input.buttonNorth = gpad.buttonNorth.wasPressedThisFrame;
            input.buttonSouth = gpad.buttonSouth.wasPressedThisFrame;
            input.buttonEast = gpad.buttonEast.wasPressedThisFrame;
            input.buttonWest = gpad.buttonWest.wasPressedThisFrame;
            input.startButton = gpad.startButton.wasPressedThisFrame;
            input.selectButton = gpad.selectButton.wasPressedThisFrame;
        }

        return input; 
    }


}
