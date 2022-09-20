using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Vector3 startPos, endPos, direction;

    public Rigidbody ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        startPos = Input.mousePosition;
    }
    private void OnMouseUp()
    {
        endPos = Input.mousePosition;
        direction = startPos - endPos;
        ball.AddForce(direction * 10);
    }
}
