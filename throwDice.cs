using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class throwDice : MonoBehaviour
{
    //    private float speed = 10f;
    //    private float jumpForce = 8f;
    //    private float gravity = 30f;
    private Vector3 randomRotation = Vector3.zero;
    private Vector3 randomRotationRed = Vector3.zero;
    private Vector3 randomRotationWhite = Vector3.zero;
    public Rigidbody rb;
    public Rigidbody rbRed;
    public Rigidbody rbWhite;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rbRed = transform.parent.GetChild(1).gameObject.GetComponent<Rigidbody>();
        rbWhite = transform.parent.GetChild(2).gameObject.GetComponent<Rigidbody>();
        randomRotation.x = Random.Range(-180, 180);
        randomRotation.y = Random.Range(-180, 180);
        randomRotation.z = Random.Range(-180, 180);
        randomRotationRed.x = Random.Range(-180, 180);
        randomRotationRed.y = Random.Range(-180, 180);
        randomRotationRed.z = Random.Range(-180, 180);
        randomRotationWhite.x = Random.Range(-180, 180);
        randomRotationWhite.y = Random.Range(-180, 180);
        randomRotationWhite.z = Random.Range(-180, 180);

        //transform.Rotate(randomRotation * 10f);



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")) 
        {
            Quaternion randomSpin = Quaternion.Euler(randomRotation);
            Quaternion randomSpinRed = Quaternion.Euler(randomRotationRed);
            Quaternion randomSpinWhite = Quaternion.Euler(randomRotationWhite);
            rb.useGravity = true;
            rbRed.useGravity = true;
            rbWhite.useGravity = true;
            Vector3 downSpin = randomSpin * Vector3.one;
            Vector3 downSpinRed = randomSpinRed * Vector3.one;
            Vector3 downSpinWhite = randomSpinWhite * Vector3.one;
            rb.angularVelocity = downSpin * Random.Range(15, 35);
            rbRed.angularVelocity = downSpinRed * Random.Range(15, 35);
            rbWhite.angularVelocity = downSpinWhite * Random.Range(1105, 1135);
        }
    }
}
