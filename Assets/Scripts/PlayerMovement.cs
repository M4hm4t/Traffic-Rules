using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class PlayerMovement : MonoBehaviour
{
    public PathCreator path;
    public EndOfPathInstruction end;
    public float movementSpeed;
    float movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement += movementSpeed* Time.deltaTime;
        transform.position=path.path.GetPointAtDistance(movement,end);
        transform.rotation=path.path.GetRotationAtDistance(movement,end);
        if (Input.GetMouseButton(0))
        {
            movementSpeed = 0;
        }else
        {
            movementSpeed = 8;
        }
    }
}
