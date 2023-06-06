using UnityEngine;

public class foodscript : MonoBehaviour
{
    
    public GameObject foodfab;
    public movetowards mv;
    public movetokennel mk;
    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.CompareTag("DogFood"))
        {
           
            if (this.transform.childCount == 2)
            {
                Debug.Log("haschild");
                   GameObject foodfabinstance = Instantiate(foodfab);


                foodfabinstance.transform.SetParent(this.transform);
                foodfabinstance.transform.localPosition = new Vector3(0.02f, 0.73f, 5f);
               foodfabinstance.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
                mv.p1currenttask = movetowards.whichtask.food;
                mk.obj1 = "food";
            }
            else
            {
                Debug.Log("4");
                Debug.Log("too many babies");
            }
        }
    }

  
}
