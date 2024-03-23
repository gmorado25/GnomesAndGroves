using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGnome : MonoBehaviour
{
    private float speed = 10.0f;
    private float rotSpeed = 100f;
    private float horizontalInput;
    private float verticalInput;
    private float rotAmount;
    //private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = -1 * Input.GetAxis("Vertical");

        // Set IsRunning parameter based on input
        //bool isRunning = (Mathf.Abs(horizontalInput) > 0.1f || Mathf.Abs(verticalInput) > 0.1f);
        //animator.SetBool("IsRun", isRunning);

        Vector3 move = new Vector3(verticalInput, 0f, 0f).normalized;
        if (verticalInput != 0)
        {
            transform.Translate(move * speed * Time.deltaTime, Space.Self);
        }
        else 
        {
            if (verticalInput > 0)
                transform.Translate(move * speed * Time.deltaTime, Space.Self);
        }

        rotAmount = horizontalInput * rotSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up * rotAmount);
    }
}