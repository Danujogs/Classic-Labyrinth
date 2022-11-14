using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugMove : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed = 10f;
    [SerializeField] float force = 1f;
    Vector3 moveDirection;
    void Update()
    {
        moveDirection = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            0,
            Input.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate()
    {
        if (moveDirection != Vector3.zero)
        {
            rb.AddForce(moveDirection * force, ForceMode.Force);
        }
    }
}
