using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicSphere : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        // rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(10, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
