using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charview : MonoBehaviour
{
    Animator myAnim;

    private void Awake()
    {
        myAnim = GetComponentInChildren<Animator>();
    }

    public void Isrunning(bool running)
    {
        myAnim.SetBool("isrunning", running);
    }
}
