using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D _rigidbody;
    public float playerSpeed = 10f;
    private Vector2 _movement;
    private float oldY;
    void Awake() {
        _rigidbody = gameObject.GetComponent<Rigidbody2D>();    
    }

    void FixedUpdate() {
        float directionX = Input.GetAxisRaw("Horizontal");
        _movement = new Vector2(directionX, 0f).normalized;
        _rigidbody.AddForce(_movement * playerSpeed);
        if(Input.GetAxisRaw("Horizontal")==0){
            oldY = _rigidbody.velocity.y;
            _rigidbody.velocity = new Vector2(0f, oldY);
        }
    }
}
