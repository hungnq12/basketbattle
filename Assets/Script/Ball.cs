using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Ball : MonoBehaviour
{
    Vector3 startPos, endPos, direction, tempPos;

    public Rigidbody ball;

    public LineRenderer line;

    public Collider goal;

    public Transform leftHand;
    public Transform rightHand;
    public Transform character;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leftHand.position = transform.position;
        rightHand.position = transform.position;
        character.position = transform.position;
    }

    private void OnMouseDown()
    {
        startPos = Input.mousePosition;
    }
    private void OnMouseDrag()
    {
        line.enabled = true;
        tempPos = Input.mousePosition;
        //tempPos = UnityEngine.Camera.main.ScreenToWorldPoint(Input.mousePosition);
        tempPos = new Vector3(tempPos.x, tempPos.y, transform.position.z);
;       line.positionCount = 1;
        line.SetPosition(0, ball.position);
        line.positionCount = 2;
        line.SetPosition(1, tempPos);
    }
    private void OnMouseUp()
    {
        line.enabled = false;
        endPos = Input.mousePosition;
        direction = startPos - endPos;
        ball.AddForce(direction * -20);
    }
    private void OnTriggerEnter(Collider goal)
    {
        Debug.Log("Hit");
    }
}
