using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colldierforanimals : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PLayerone; // The specific GameObject to detect
    GameObject panel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == PLayerone)
        {
          
        }
    }

    private void OnMouseDown()
    {
        // Run your code here
        Debug.Log("GameObject clicked!");


    }
}

