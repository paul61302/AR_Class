using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class buttonControll : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject Box;
    bool a;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        a = true;
        print(vb.name + " 按鈕被按下");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        a = false;
        print(vb.name + " 按鈕被放開");
    }

    void Start()
    {
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; i++) { vbs[i].RegisterEventHandler(this); }
    }

    void Update()
    {
        if (a)
        {
            Box.transform.Rotate(0, 2, 0);
        }
    }
}
