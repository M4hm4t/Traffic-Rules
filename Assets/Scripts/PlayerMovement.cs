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
    public GameObject stop;
    // public Transform lw, rw;// sað ve sol arka lastikler 
    public GameObject lw;//arka sol lastik trail
    public GameObject rw;//arka sað lastik trail

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movement += movementSpeed * Time.deltaTime;
        transform.position = path.path.GetPointAtDistance(movement, end);
        transform.rotation = path.path.GetRotationAtDistance(movement, end);
       
        if (Input.GetMouseButton(0))
        {
            
            lw.gameObject.GetComponent<TrailRenderer>().emitting = true;
            rw.gameObject.GetComponent<TrailRenderer>().emitting = true;
            this.movementSpeed *= 0.96f;
        }
        else
        {
            
            lw.gameObject.GetComponent<TrailRenderer>().emitting = false;
            rw.gameObject.GetComponent<TrailRenderer>().emitting = false;
            movementSpeed = 10;
        }
    }

    public void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag == "OtherCars")
        {
            stop.GetComponent<PlayerMovement>().enabled = false;
        }else
        {
           // movementSpeed = 10;
        }
    }
}
