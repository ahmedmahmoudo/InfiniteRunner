using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float currentSpeed = 1f;

    [SerializeField]
    private float maxSpeed = 30;

    private Rigidbody2D mRigidBody;

    private Animator mAnimator;

    private bool gameStarted = false;


    void Start()
    {
        mRigidBody = GetComponent<Rigidbody2D>();
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameStarted)
        {
            mRigidBody.velocity = new Vector2(currentSpeed, mRigidBody.velocity.y);

            mAnimator.SetBool("IsRunning", true);

            if (currentSpeed < maxSpeed)
            {
                currentSpeed += 0.1f * Time.deltaTime;
            }


            if (mRigidBody.velocity.y != 0 && transform.position.y > -0.26f)
            {
                mRigidBody.velocity = new Vector2(mRigidBody.velocity.x, -2.0f);
            }
            else if (transform.position.y <= -1.26f)
            {
                mRigidBody.velocity = new Vector2(mRigidBody.velocity.x, 0f);
            }

            if (Input.GetKeyDown(KeyCode.Space) && mRigidBody.velocity.y == 0)
            {
                mRigidBody.velocity = new Vector2(mRigidBody.velocity.x, 3.0f);
            }


            
        }

        if(Input.GetKeyDown(KeyCode.Return))
        {
            if (!gameStarted) gameStarted = true;
        }

    }
}
