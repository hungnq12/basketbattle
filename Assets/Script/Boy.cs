using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boy : MonoBehaviour
{
    public Transform ball;
    public Transform leftHand;
    public Transform rightHand;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        leftHand.position = ball.position;
        rightHand.position = ball.position;
        transform.position = ball.position;
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1);
    }
}
