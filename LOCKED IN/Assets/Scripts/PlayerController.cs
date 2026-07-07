using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private Vector2 _posLimit;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void CalculateMovement()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");


        _rb.velocity = new Vector2(xInput, yInput).normalized * _speed;


        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, -_posLimit.x, _posLimit.x),
            Mathf.Clamp(transform.position.y, -_posLimit.y, _posLimit.y));

    }

    
    // Update is called once per frame
    void Update()
    {
        CalculateMovement();
    }
}
