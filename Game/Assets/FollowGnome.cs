using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowGnome : MonoBehaviour
{
    public GameObject gnome;
    private Vector3 offset = new Vector3(10, 5, 0);
    //private float smoothSpeed = 0.125f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = gnome.transform.position + offset;

        transform.LookAt(gnome.transform.position);
    }
}
