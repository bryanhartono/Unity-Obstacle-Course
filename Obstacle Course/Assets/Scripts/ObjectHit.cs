using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer renderer;
    private void Start() 
    {
        renderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision other) 
    {
        // Debug.Log("You bumped into a wall.");

        if (other.gameObject.tag == "Player")
        {
            renderer.material.color = Color.red;
            gameObject.tag = "Hit";
        }
    }
}
