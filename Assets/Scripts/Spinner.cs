using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    private readonly int rotationSpeed = 60;

    private void Update()
    {
        transform.Rotate(0, 1 * Time.deltaTime * this.rotationSpeed, 0);
    }
}
