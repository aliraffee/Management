using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attentionscript : MonoBehaviour
{

    public movetowards mv;
    public GameObject attentionspace;
    private bool occupied = false;
    public dog1script dgscript;


    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("1");
        if (other.CompareTag("Attentionspace"))
        {
            //Debug.Log("2");
            if (occupied == false)
            {
               // Debug.Log("3");
                if (this.transform.childCount == 3)
                {
                    Transform childToAttach = transform.GetChild(2);
                    childToAttach.SetParent(attentionspace.transform, true);
                    childToAttach.transform.localPosition=new Vector2(0,0);
                    occupied = true;
                    Debug.Log("4");
                }
                else
                {

                    Debug.Log("too little babies");
                }
            }
            else
            {
                Transform dogtrns = transform.GetChild(1);
                dgscript = dogtrns.GetComponent<dog1script>();
                int bath = dgscript.cleanliness;
                if (bath == 100)
                {

                }
            }
        }
    }


}
