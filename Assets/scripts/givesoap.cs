using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class givesoap : MonoBehaviour
{

    public GameObject soapfab;
    public movetowards mv;
    public bool soap = false;
    public movetokennel mk;
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Bath"))
        {

            if (this.transform.childCount == 2)
            {

                GameObject soapfabinstance = Instantiate(soapfab);


                soapfabinstance.transform.SetParent(this.transform);
                soapfabinstance.transform.localPosition = new Vector3(0.02f, 0.73f, 5f);
                soapfabinstance.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                mv.p2currenttask = movetowards.whichtask.bath;
                mk.obj2 = "soap";

            }
            else
            {

                Debug.Log("too many babies");
            }
        }
    }


}