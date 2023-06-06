using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dog1script : MonoBehaviour
{
    public int cleanliness;
    public AnimalStats an;
    private void Start()
    {
        Debug.Log("yes");   
    }
    private void OnMouseDown()
    {
        Debug.Log("donr");
        an.DisplayAnimalStats("Dog");
       
    }
}
