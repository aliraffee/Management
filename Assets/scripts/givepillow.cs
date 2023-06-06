using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class givepillow : MonoBehaviour
{

    public GameObject pillowfab;
    public movetowards mv;
    public bool pillow = false;
    public movetokennel mk;
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Attentionspace"))
        {

            if (this.transform.childCount == 2)
            {

                GameObject pillowfabinstance = Instantiate(pillowfab);


                pillowfabinstance.transform.SetParent(this.transform);
                pillowfabinstance.transform.localPosition = new Vector3(0.02f, 0.73f, 5f);
                pillowfabinstance.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
                mv.p2currenttask = movetowards.whichtask.attention;
                mk.obj2 = "pillow";

            }
            else
            {

                Debug.Log("too many babies");
            }
        }
    }


}

