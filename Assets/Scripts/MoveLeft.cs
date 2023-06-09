using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * _speed);
        if (transform.position.x < -15)
        {
            float randomYPosition = UnityEngine.Random.Range(-3, 3);
            transform.position = new Vector3(15, randomYPosition, 0);
        }
    }
}
