using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGnome : MonoBehaviour
{
    public float speed = 20.0f;
    public float rotSpeed = 500f;
    public float horizontalInput;
    public float verticalInput;
    public float rotAmount;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = -1 * Input.GetAxis("Vertical");

        Vector3 move = new Vector3(verticalInput, 0f, 0f).normalized;

        transform.Translate(move * speed * Time.deltaTime, Space.Self);

        rotAmount = horizontalInput * rotSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up * rotAmount);
    }
}
