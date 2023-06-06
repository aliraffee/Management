using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updatebathes : MonoBehaviour
{
    private int value = 0;
    private int childCount = 1;
    private float increaseInterval = 1f;
    private float timer = 0f;
    public AnimalStats am;
    //public GameObject btngive, btnpickup, btndrop, dog, cat, parrot, gerbil, attacthtoobj, dogholder, catholder, girbilholder, parrotholder;



    private void FixedUpdate()
    {

        if (this.transform.childCount == 2)
        {
            Transform secondChild = this.transform.GetChild(1);
            string secondChildName = secondChild.name;
            Debug.Log(secondChildName);

        }



        if (this.transform.childCount > 1)
        {
            timer += Time.deltaTime;
            if (timer >= increaseInterval)
            {
                timer = 0f;
                Transform childTransform = this.transform.GetChild(1);
                string childName = childTransform.name;



                switch (childName)

                {
                    case "dog":
                        am.dog.hygiene += 5;
                       



                        break;
                    case "cat":
                        am.cat.hygiene += 5;

                        break;
                    case "parrot":
                        am.parrot.hygiene += 5;

                        break;
                    case "gerbil":
                        am.gerbil.hygiene += 5;

                        break;

                }



            }


        }

    }
}


