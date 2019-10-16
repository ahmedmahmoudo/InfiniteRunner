using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundFollow : MonoBehaviour
{

    [SerializeField]
    private GameObject followingObject;

    [SerializeField]
    private float followingSpeed = 5.0f;
    void Start()
    {
        if(!followingObject)
        {
            //find the player to follow if there is no object to follow
            //followingObject = FindObjectOfType<Player>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position,
            new Vector3(followingObject.transform.position.x, transform.position.y, transform.position.z), followingSpeed);
    }
}
