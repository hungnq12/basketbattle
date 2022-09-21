using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform ball;
    private Vector3 ballCam;
    // Start is called before the first frame update
    void Start()
    {
        ballCam = ball.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ball.position - ballCam;
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
    }
}
