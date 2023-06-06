using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class movetokennel : MonoBehaviour
{
   
    public int skennelp1, skennelp2;
    public GameObject p1, p2;
    public movetowards mv;
    public getswater gtwater;
    public GameObject btngive, btnpickup, btndrop, dog, cat, parrot, gerbil, attacthtoobj, dogholder, catholder, girbilholder, parrotholder;
    public Animal an;
    public string obj1,obj2;
    public TextMeshProUGUI nameofanimal;
    public Canvas cv;
    // Start is called before the first frame update

    private void Start()
    {
       Debug.Log( p1.transform.childCount);
        Debug.Log(p2.transform.childCount);

    }
    public void dropoff()
    {
        
        Transform childTransform = p2.transform.GetChild(2);
        Vector3 initialScale = childTransform.localScale;
        string childName = childTransform.name;
        switch (childName)
        {
            case "dog":
                dog.transform.SetParent(cv.transform, false);
                dog.transform.position = dogholder.transform.position;


                break;
            case "cat":
                cat.transform.SetParent(cv.transform, false);
                cat.transform.position = catholder.transform.position;


                break;
            case "parrot":
                parrot.transform.SetParent(cv.transform, false);
                parrot.transform.position = parrotholder.transform.position;


                break;
            case "girbil":
                gerbil.transform.SetParent(cv.transform, false);
                gerbil.transform.position = girbilholder.transform.position;


                break;

        }
        childTransform.localScale = initialScale * transform.parent.lossyScale.magnitude;
    }

    public void pickup()
    {
        if (p2.transform.childCount == 2)
        {
           
            switch (nameofanimal.text)
            {
                case "Dog":
                    attacthtoobj = dog;
                   

                    break;
                case "Cat":
                    attacthtoobj = cat;

                    break;
                case "Parrot":
                    attacthtoobj = parrot;

                    break;
                case "Gerbil":
                    attacthtoobj = gerbil;

                    break;
            }
            attacthtoobj.transform.SetParent(p2.transform);
            attacthtoobj.transform.localPosition = new Vector2(0, 00);
        }
    }
    public void clicks()
    {
        
        if (mv.currentplayer == movetowards.whichplayer.playerone)
        {
            skennelp1 = 2;
            gtwater.swater = 0;
            gtwater.stoy = 0;
            
        }else
        {
            skennelp2 = 2;
            gtwater.sbath = 0;
            gtwater.satt = 0;
        }
    }

  
    public void givefood()
    {
        Debug.Log(p1.transform.childCount);
        //string childName = p1.transform.GetChild(2).name;
       
        if (obj1 == "food")
        {
            an.food += 30;

            Transform childTransform = p1.transform.GetChild(2);
            Destroy(childTransform.gameObject);
            obj1 = "none";
        }
        if(obj1 == "toy")
        {
            an.toy += 30;

            Transform childTransform = p1.transform.GetChild(2);
            Destroy(childTransform.gameObject);
            obj1 = "none";
        }
        if (obj2 == "pillow")
        {
            an.sleep += 30;

            Transform childTransform = p2.transform.GetChild(2);
            Destroy(childTransform.gameObject);
            obj2 = "none";
        }
        if (obj2 == "soap")
        {
            an.hygiene += 30;

            Transform childTransform = p2.transform.GetChild(2);
            Destroy(childTransform.gameObject);
            obj2 = "none";
        }



    }


    public void FixedUpdate()
    {

        p1.transform.position = Vector3.MoveTowards(p1.transform.position, this.transform.position, skennelp1);
        p2.transform.position = Vector3.MoveTowards(p2.transform.position, this.transform.position, skennelp2);
        if (p1.transform.position==this.transform.position || p2.transform.position == this.transform.position)
        {
            if (p1.transform.childCount == 3|| p2.transform.childCount == 3)
            {
                btngive.SetActive(true);

            }
        }else
        {
            btngive.SetActive(false);
        }
       /* if (p2.transform.position == this.transform.position || p2.transform.position == this.transform.parent.position)
        {
            if (p2.transform.childCount == 3)
            {
                btndrop.SetActive(true);
                btnpickup.SetActive(false);

            }
            if (p2.transform.childCount == 2)
            {
                btnpickup.SetActive(true);

                btndrop.SetActive(false);

            }
        }else
        {
            btndrop.SetActive(false);
            btnpickup.SetActive(false);
        }
*/
    }
}