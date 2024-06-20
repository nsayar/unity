using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class movement : MonoBehaviour
{
    public SpriteRenderer sprite;
    public float speed = 5f;
    public Rigidbody2D rigid;
    public KeyCode UpkKey = KeyCode.W;
    public KeyCode downkKey = KeyCode.S;
    // Start is called before the first frame update
    void Start()
    { print("hello from the start");
        sprite = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(UpkKey)&& transform.position.y <4.5f)
        {
            rigid.velocity = Vector2.up*speed; 
        }
        else if (Input.GetKey(downkKey)&& transform.position.y >-4.5f) 
        {
            rigid.velocity =Vector2.down*speed;
        }
        else
        {
            rigid.velocity = Vector2.zero;
        }
    }
    
    private void OnMouseDown()
    {
        sprite.color = Color.red;
    }
    
}