using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetowards : MonoBehaviour
/*how game will work
    player will click on a worker then a task, if the selected worker can do the task it will move towards the task and stay theree util task is complete.


*/
{
   
    public enum whichplayer { playerone=1, playertwo=2, none=0 };
   public  whichplayer currentplayer;
    public enum whichtask {none=0,bath=1,toy=2,food=3,attention=4 }
    public whichtask p1currenttask, p2currenttask;


    public void Start()
    {
        currentplayer = whichplayer.none;
        Debug.Log(currentplayer);

    }

    public void selectplayerone()
    {
        currentplayer = whichplayer.playerone;
        Debug.Log(currentplayer);

    }

    public void selectplayertwo()
    {
        currentplayer = whichplayer.playertwo;
        Debug.Log(currentplayer);

    }
   
}

