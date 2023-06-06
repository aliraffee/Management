using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;
public class battery : MonoBehaviour
{
    private float batterylife;
    public Slider slid;
    public GameObject prefabdeadbattery;
    int i;
    public deadbot db;
    public GameObject targetObject; // The specific object you want to collide with
    public int variableToChange; // The variable you want to change
    public GameObject battbox;
    GameObject daedbattery;

    // Start is called before the first frame update
    void Start()
    {
        batterylife = 100f;
        slid.value = batterylife;
        InvokeRepeating("bat", 1f, 1f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

       if (db.deadplayer.transform.position==battbox.transform.position|| db.deadplayer.transform.parent.position == battbox.transform.position )
        {
            Destroy(daedbattery);
            this.gameObject.SetActive(true);
            transform.position = battbox.transform.position;
        }
        
    }
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == targetObject)
        {
            // Collided with the specific object
            batterylife = 100;
            slid.value = batterylife;
        }
    }

    void bat()
    {
      
        i++;
        //Debug.Log(i);

        batterylife = 100;
       
            slid.value = batterylife;
            

            if (batterylife == 0)
            {
                 daedbattery = Instantiate(prefabdeadbattery, this.gameObject.transform.position, transform.rotation);
            Canvas canvas = GameObject.FindWithTag("can").GetComponent<Canvas>();
            daedbattery.transform.SetParent(canvas.transform, false);
            this.gameObject.SetActive(false);
            string objectName = gameObject.name;
            if (objectName== "playerA")
            {
                db.setp2();
            }else
            {
                db.setp1();
            }
        }
        
    }
}
