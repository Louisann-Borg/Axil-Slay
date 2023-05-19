using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axil : MonoBehaviour
{
    [SerializeField]
    private float _upwardForceMultiplier = 100f;
    public float moveSpeed = 5f;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(Vector3.up * _upwardForceMultiplier);
        }

        if (transform.position.y > 6f || transform.position.y < -6f)
        {
            Application.LoadLevel(3);
        }
    }
}
