using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updclean : MonoBehaviour
{
    private int value = 0;
    private int childCount = 1;
    private float increaseInterval = 1f;
    private float timer = 0f;
    public AnimalStats am;
    public GameObject btngive, btnpickup, btndrop, dog, cat, parrot, gerbil, attacthtoobj, dogholder, catholder, girbilholder, parrotholder;

   

    private void FixedUpdate()
    {

        if (transform.childCount >= 2)
        {
            Transform secondChild = transform.GetChild(1);
            string secondChildName = secondChild.name;

        }



        if (transform.childCount > childCount)
        {
            timer += Time.deltaTime;
            if (timer >= increaseInterval)
            {
                timer = 0f;
                Transform childTransform = this.transform.GetChild(2);
                string childName = childTransform.name;



                switch (childName)

                {
                    case "Dog":
                        am.dog.hygiene += 5;



                        break;
                    case "Cat":
                        am.cat.hygiene += 5;

                        break;
                    case "Parrot":
                        am.parrot.hygiene += 5;

                        break;
                    case "Gerbil":
                        am.gerbil.hygiene += 5;

                        break;

                }



            }


        }

    }
}


