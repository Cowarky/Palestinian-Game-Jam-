using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed, sprintSpeed, JumpForce;
    Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxisRaw("Horizontal");

        //check position
        position = transform.position; // get the position
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;


        Debug.Log(movement);
       
        //Spinting
        if (Input.GetKey(KeyCode.DownArrow))
        {
            // rb.AddForce(new Vector2(sprintSpeed,0), ForceMode2D.Impulse);
            transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * sprintSpeed;


        }
    }
}
