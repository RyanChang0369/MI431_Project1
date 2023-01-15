using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class CallVFXEvent : MonoBehaviour
{
    public VisualEffect vfx;

    public void CallEvent(string eventName)
    {
        vfx.SendEvent(eventName);
    }
}
