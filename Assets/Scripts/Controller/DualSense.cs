using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.DualShock;

public class DualSense : MonoBehaviour
{

    DualSenseGamepadHID bestController = (DualSenseGamepadHID)Gamepad.current;

    // Start is called before the first frame update
    void Start()
    {
        // PlayStation 2 is alive in all successors forever <3
        bestController.SetLightBarColor(new Color(0.35f, 0.05f, 0.65f, 1.0f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
