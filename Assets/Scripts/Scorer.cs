using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int score = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Hitted"))
        {
            this.score++;
            Debug.Log("You've bumped into a thing this many times: " + this.score);
        }
    }
}
