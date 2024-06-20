using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D Rigidbody2D;
    public float speed = 6f;
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        


    }

    private void SendBallinRandomDirection()
    {
        Rigidbody2D.velocity = Vector3.zero;
        Rigidbody2D.isKinematic = true;
        transform.position = Vector3.zero;
        Rigidbody2D.isKinematic = false;
        
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Vector2 newBallVector = new Vector2();
        newBallVector.x = Random.Range(-if, if);
        newBallVector.y = Random.Range(If, if);
        Rigidbody2D.velocity = newBallVector * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
