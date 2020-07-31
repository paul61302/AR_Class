using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator ani;

    private void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetKey("up"))
        {
            ani.SetBool("IsRun", true);
        }
        else
        {
            ani.SetBool("IsRun", false);
        }
    }
}
