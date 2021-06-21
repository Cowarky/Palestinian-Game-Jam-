using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Parentt_Player : MonoBehaviour
{
    Transform body;
    float animationDuration = 4f;

    // Start is called before the first frame update
    void Start()
    {
        body = transform;
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }

    private void Jump() 
    {
        if (Input.GetKeyDown("up"))
        {
            body.DOJump(body.position, 2f, 1, animationDuration, false);
        }
    }
}
