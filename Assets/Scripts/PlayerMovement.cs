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
    // public Transform lw, rw;// sa� ve sol arka lastikler 
    public GameObject lw;//arka sol lastik trail
    public GameObject rw;//arka sa� lastik trail
    public GameObject con; // continue
  public AudioSource brake;
    public AudioClip clipBreak;

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
        if (Input.GetMouseButtonDown(0))
        {
            brake.PlayOneShot(clipBreak);
        }
    }

    public void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag == "OtherCars")
        {
            stop.GetComponent<PlayerMovement>().enabled = false;
            con.gameObject.SetActive(true);
        }
        else
        {
           // movementSpeed = 10;
        }
    }

    
}
