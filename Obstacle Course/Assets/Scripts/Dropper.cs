using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float time_to_wait = 5;

    // Start is called before the first frame update
    void Start()
    {
        // This is cashing
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > time_to_wait)
        {
            Debug.Log("Watch our for the dropper!");
            
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
