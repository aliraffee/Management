using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deadbot : MonoBehaviour
{
    public GameObject player1, player2, currentplayer, deadplayer;
    public bool isdeadplayer=false;
    public getswater wt;
    public int move, movetobattery;
    public GameObject deadnattery;
    public movetowards movetwrds;

    bool deadp1, deadp2 = false;
        
    // Start is called before the first frame update
   public void pickupbot()
    {

        deadplayer.transform.position = currentplayer.transform.position;
         

    }
    private void FixedUpdate()
    {
        Debug.Log(isdeadplayer);
        Debug.Log(movetwrds.currentplayer);

        if (!isdeadplayer)
        {
            Debug.Log(isdeadplayer);
            if (movetwrds.currentplayer == movetowards.whichplayer.playerone)
            {
                Debug.Log(movetobattery);
              
                player1.transform.position = Vector3.MoveTowards(player1.transform.position, deadnattery.transform.position, movetobattery);

            }
            if (movetwrds.currentplayer == movetowards.whichplayer.playertwo)
            {

                Debug.Log("ok");
                player2.transform.position = Vector3.MoveTowards(currentplayer.transform.position, deadnattery.transform.position, movetobattery);

            }
           
        }
        if (isdeadplayer)
        {
            currentplayer.transform.position = Vector3.MoveTowards(currentplayer.transform.position, deadnattery.transform.position, movetobattery);
            currentplayer.transform.position = Vector3.MoveTowards(currentplayer.transform.position, deadplayer.transform.position, move);
            if (deadplayer.transform.position == currentplayer.transform.position)
            {
                pickupbot();
            }
        }
    }
    public void movetodead()
    {

        //get co ord of dead bot move towards bot
        wt.swater = 0;
        wt.stoy = 0;
        wt.satt = 0;
        wt.sbath = 0;
        move = 2;
        movetobattery = 0;
        isdeadplayer = false;


    }

    public void movetobatery()
    {

        //get co ord of dead bot move towards bot
        wt.swater = 0;
        wt.stoy = 0;
        wt.satt = 0;
        wt.sbath = 0;
        move = 0;
        movetobattery = 2;


    }

    public void setp1()
    {
        currentplayer = player1;
        deadplayer = player2;
        isdeadplayer = true;
    }
    public void setp2()
    {
        currentplayer = player2;
        deadplayer = player1;
        isdeadplayer = true;

    }
}
