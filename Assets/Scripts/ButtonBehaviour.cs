using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonBehaviour : MonoBehaviour
{
    public GameObject obj;
    VirtualButtonBehaviour vrb;
    // Start is called before the first frame update
    void Start()
    {
        obj.SetActive(false);
        vrb = GetComponentInChildren<VirtualButtonBehaviour>();
        vrb.RegisterOnButtonPressed(OnButtonPressed);
        vrb.RegisterOnButtonReleased(OnButtonReleased);
    }

    void OnButtonPressed (VirtualButtonBehaviour vb)
    {
        obj.SetActive(true);
    }

    void OnButtonReleased (VirtualButtonBehaviour vb)
    {
        obj.SetActive(false);
    }
}
