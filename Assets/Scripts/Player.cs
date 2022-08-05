using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private readonly float movimentSpeed = 15;

    private void Update()
    {
        this.MovePlayer();
    }

    void MovePlayer()
    {
        float xDirection = Input.GetAxis("Horizontal") * Time.deltaTime * this.movimentSpeed;
        float zDirection = Input.GetAxis("Vertical") * Time.deltaTime * this.movimentSpeed;

        transform.Translate(xDirection, 0, zDirection);
    }
}
