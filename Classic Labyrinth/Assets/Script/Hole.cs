using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    bool entered = false;

    public bool Entered { get => entered; }

    private void OnTriggerEnter(Collider other)
    {
        entered = true;
    }
}
