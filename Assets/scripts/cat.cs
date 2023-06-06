using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour
{
    public AnimalStats an;
    private void OnMouseDown()
    {

        an.DisplayAnimalStats("Cat");

    }
}