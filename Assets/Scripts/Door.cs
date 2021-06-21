using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Door : MonoBehaviour
{
    Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        Open_Door();

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void Open_Door() {
        if(gameObject.CompareTag("Door 1"))
            {
            gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
            transform.DOLocalMoveX(body.position.x+2,4f,false);
            }
    }
}
