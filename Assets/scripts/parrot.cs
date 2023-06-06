using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parrot : MonoBehaviour
{
    public AnimalStats an;
    private void OnMouseDown()
    {
     
        an.DisplayAnimalStats("Parrot");

    }
}
