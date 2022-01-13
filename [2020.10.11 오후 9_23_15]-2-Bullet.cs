using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bulletRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = transform.forward * speed;
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        UnityEngine.Debug.Log("Trigger !" + other.gameObject.name + "tag : " + other.tag);

        if(other.tag == "Player")
        {
            ballController pController = other.GetComponent<ballController>();

            if (pController != null)
                pController.Die();
        }
    }
}
