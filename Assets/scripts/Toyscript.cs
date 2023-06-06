using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toyscript : MonoBehaviour
{

    public GameObject toyfab;
    public movetowards mv;
    public bool toy=false;
    public movetokennel mk;
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Toysfab"))
        {

            if (this.transform.childCount == 2)
            {

                GameObject Toysfabinstance = Instantiate(toyfab);


                Toysfabinstance.transform.SetParent(this.transform);
                Toysfabinstance.transform.localPosition = new Vector3(0.02f, 0.73f, 5f);
                Toysfabinstance.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                mv.p1currenttask = movetowards.whichtask.toy;
                mk.obj1 = "toy";
                
            }
            else
            {
               
                Debug.Log("too many babies");
            }
        }
    }


}

