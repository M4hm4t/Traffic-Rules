using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject con;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            con.gameObject.SetActive(true);
        }
    }
}
