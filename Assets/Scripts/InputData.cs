using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Mirrors Unity Gamepad Structure
// https://docs.unity3d.com/Packages/com.unity.inputsystem@1.4/manual/Gamepad.html
public struct InputData
{
    public Vector2 leftStick;
    public Vector2 rightStick;
    public Vector2 dpad;
    public bool buttonNorth;
    public bool buttonSouth;
    public bool buttonWest;
    public bool buttonEast;
    public bool leftShoulder;
    public bool rightShoulder;
    public float leftTrigger;
    public float rightTrigger;
    public bool startButton;
    public bool selectButton;
    public bool leftStickButton;
    public bool rightStickButton;

    public static InputData CleanDataStruct()
    {
        InputData newData = new InputData();
 
        newData.leftStick = Vector2.zero;
        newData.rightStick = Vector2.zero;
        newData.dpad = Vector2.zero;
        newData.buttonNorth = false;
        newData.buttonSouth = false;
        newData.buttonWest = false;
        newData.buttonEast = false;
        newData.leftShoulder = false;
        newData.rightShoulder = false;
        newData.leftTrigger = 0;
        newData.rightTrigger = 0;
        newData.startButton = false;
        newData.selectButton = false;
        newData.leftStickButton = false;
        newData.rightStickButton = false;

        return newData;
    }
}
