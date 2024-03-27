using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatFlower : MonoBehaviour
{
    public GameObject petal;

    private Vector3 startPos;
    private float floatHeight = 0.17f;
    private float floatSpeed = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newPos = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        transform.position = new Vector3(transform.position.x, newPos, transform.position.z);
    }

    public void Explode()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 petalPos = transform.position + Vector3.up * 0.1f;
            GameObject p = Instantiate(petal, transform.position, Quaternion.identity);
            Rigidbody rb = p.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Vector3 explosionDir = Random.insideUnitSphere;
                float explosionForce = Random.Range(1f, 3f);
                rb.AddForce(explosionDir * explosionForce, ForceMode.Impulse);
            }
        }
        Destroy(gameObject);
    }
}