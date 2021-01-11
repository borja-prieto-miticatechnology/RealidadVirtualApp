using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class TabletToggle : MonoBehaviour
{
    public VRTK_ControllerEvents controllerEvents;
    public GameObject tablet;
    public GameObject canvas;

    bool tabletState=false;

    void OnEnable()
    {
        controllerEvents.ButtonTwoPressed += ControllerEvents_ButtonTwoPressed;
        controllerEvents.ButtonTwoReleased += ControllerEvents_ButtonTwoReleased;
    }

    void OnDisable()
    {
        controllerEvents.ButtonTwoPressed -= ControllerEvents_ButtonTwoPressed;
        controllerEvents.ButtonTwoReleased -= ControllerEvents_ButtonTwoReleased;
    }

    private void ControllerEvents_ButtonTwoReleased(object sender, ControllerInteractionEventArgs e)
    {
        tabletState = !tabletState;
        canvas.SetActive(tabletState);
        tablet.SetActive(tabletState);
    }

    private void ControllerEvents_ButtonTwoPressed(object sender, ControllerInteractionEventArgs e)
    {
        
    }
}
