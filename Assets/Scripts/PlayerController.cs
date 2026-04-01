using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    CharacterController chc;

    float y = 0f;

    private void Start()
    {
        chc = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        if (chc.isGrounded)
        {
            if (y < 0) y = -2f;
            if(Input.GetKeyDown(KeyCode.Space))
            {
                y = 5f;
            }
        }

        chc.Move(move * Time.deltaTime);

    }
}