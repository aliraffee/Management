using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bath : MonoBehaviour
{
   
    public movetowards mv;
    public GameObject showerspace; 
    private bool occupied=false;
    public dog1script dgscript;
   
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("1");
        if (other.CompareTag("Bath"))
        {
            Debug.Log("2");
            if (occupied == false)
            {
                Debug.Log("3");
                if (this.transform.childCount == 3)
                {
                    Transform childToAttach = transform.GetChild(2);
                    childToAttach.SetParent(showerspace.transform, true);
                    occupied = true;
                    Debug.Log("4");
                }
                else
                {
                    occupied = false;

                    Debug.Log("too little babies");
                }
            }else
            {
                Transform dogtrns = transform.GetChild(2);
                 dgscript = dogtrns.GetComponent<dog1script>();
                int bath = dgscript.cleanliness;
              
            }
        }
    }


}
