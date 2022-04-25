using PathCreation;
using PathCreation.Examples;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCar1 : MonoBehaviour
{
    public GameObject triggerCar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            triggerCar.GetComponent<PathFollower>().enabled = true;
        }  
    }
}
