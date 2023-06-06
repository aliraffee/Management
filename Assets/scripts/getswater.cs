using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getswater : MonoBehaviour
{
    // Start is called before the first frame update
    public movetowards mv;
    public GameObject player1, player2, waterstation, toy, bath, attention;
    public int swater, stoy, sbath, satt;
    public bool playable1, playable2;
    public deadbot db;
    public movetokennel mk;
   
    public void Start()
    {
        playable1 = true;
        playable2 = true;
        swater = 0;
        stoy = 0;
        sbath = 0;
        satt = 0;

        mk.skennelp1 = 0;
        mk.skennelp2 = 0;
        db.move=0;

     
    }
    public void FixedUpdate()
    {
      
        player1.transform.position = Vector3.MoveTowards(player1.transform.position, waterstation.transform.position, swater);
        player1.transform.position = Vector3.MoveTowards(player1.transform.position, toy.transform.position, stoy);
        player2.transform.position = Vector3.MoveTowards(player2.transform.position, bath.transform.position, sbath);
        player2.transform.position = Vector3.MoveTowards(player2.transform.position, attention.transform.position, satt);
        if (player1.transform.position == waterstation.transform.position)
        {
            swater = 0;
            playable1 = true;

        }
        if (player1.transform.position == toy.transform.position)
        {
            stoy = 0;
            playable1 = true;

        }
        if (player2.transform.position == bath.transform.position)
        {
            sbath = 0;
            playable2 = true;


        }
        if (player2.transform.position == attention.transform.position)
        {
            satt = 0;
            playable2 = true;


        }

    }
    public void mvwaater()
    {
        if (mv.currentplayer == movetowards.whichplayer.playerone)
        {
            if (playable1 == true)
            {
                // playable1 = false;
                db.move = 0;
                stoy = 0;
                mk.skennelp1 = 0;
                mk.skennelp2 = 0;
               

                swater = 2;
                if (player1.transform.position == waterstation.transform.position)
                {
                    swater = 0;
                    Debug.Log("end");

                }
            }



        }
    }
    public void batterygo()
    {
        if (mv.currentplayer == movetowards.whichplayer.playerone)
        {
            if (playable1 == true)
            {
                // playable1 = false;
                db.move = 0;
                stoy = 0;
                mk.skennelp1 = 0;
                mk.skennelp2 = 0;


                swater = 2;
                if (player1.transform.position == waterstation.transform.position)
                {
                    swater = 0;
                    Debug.Log("end");

                }
            }



        }
    }
    public void mvtoy()
    {
        // Debug.Log("A");
        if (mv.currentplayer == movetowards.whichplayer.playerone)
        {
            //Debug.Log("b");
            if (playable1 == true)
            {
                // Debug.Log("c");
                //  playable1 = false;
                swater = 0;
                mk.skennelp1 = 0;
                mk.skennelp2 = 0;



                db.move = 0;

                stoy = 2;
                if (player1.transform.position == toy.transform.position)
                {
                    Debug.Log("d");
                    stoy = 0;

                }
            }




        }
    }
    public void mvbath()
    {
        if (mv.currentplayer == movetowards.whichplayer.playertwo)
        {
            if (playable2 == true)
            {


                satt = 0;
                db.move = 0;
                mk.skennelp1 = 0;
                mk.skennelp2 = 0;

                sbath = 2;
                // playable2 = false;


                if (player2.transform.position == bath.transform.position)
                {
                    sbath = 0;

                }
            }



        }
    }

    public void mvpattention()
    {
        if (mv.currentplayer == movetowards.whichplayer.playertwo)
        {
            if (playable2 == true)
            {

                sbath = 0;
                mk.skennelp1 = 0;
                mk.skennelp2 = 0;

                db.move = 0;
                satt = 2;
                //  playable2 = false;


                if (player2.transform.position == attention.transform.position)
                {
                    satt = 0;

                }
            }



        }

    }
}



/*{
   
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Get the mouse click position
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0f; // Assuming you're working in 2D, set the Z-coordinate to 0

            // Set the target position and start moving
            targetPosition = mousePosition;
            isMoving = true;
        }

        if (isMoving)
        {
            // Calculate the direction towards the target position
           

            // Set the movement speed
            float moveSpeed = 50f; // Adjust this value to control the movement speed

            // Move towards the target position
            if (mv.currentplayer == movetowards.whichplayer.playerone)
            {
                Vector3 direction = targetPosition - player1.transform.position;
                direction.Normalize();
                player1.transform.position += direction * moveSpeed * Time.deltaTime;
            }
            else
            {
                Vector3 direction = targetPosition - player2.transform.position;
                direction.Normalize();
                player2.transform.position += direction * moveSpeed * Time.deltaTime;
            }

        }
    }
*/



