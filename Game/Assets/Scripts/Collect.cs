using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    private int score = 0;
    //public Text textScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    { 
        if (collider.CompareTag("Flower"))
        {
            score++;
            //UpdateScore();
            FloatFlower ff = collider.GetComponent<FloatFlower>();
            if (ff != null)
                ff.Explode();
            //Destroy(collider.gameObject);
        }
    }

    // Update is called once per frame
    /*void UpdateScore()
    {
        if (textScore != null)
            textScore.text = "Score: " + score;
    }*/
}
