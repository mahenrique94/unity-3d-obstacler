using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField]
    private int timeForWait = 3;
    private Rigidbody rb;
    private MeshRenderer mr;

    private void Start()
    {
        this.rb = GetComponent<Rigidbody>();
        this.mr = GetComponent<MeshRenderer>();

        this.mr.enabled = false;
    }

    void Update()
    {
        if (Time.time > this.timeForWait)
        {
            this.rb.useGravity = true;
            this.mr.enabled = true;
        }
    }
}
