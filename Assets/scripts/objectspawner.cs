/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class objectspawner : MonoBehaviour
{
    public GameObject button;
    public float enableInterval = 10f;


    private float timer = 0f;
    private bool isEnabled = false;
    public battery bat1, bat2;
    public movetowards mv;

    private void Update()
    {

        timer += Time.deltaTime;


        if (timer >= enableInterval)
        {
            timer = 0f;
            button.SetActive(true);
        }
    }

    private void EnableButton()
    {
        button.SetActive(false);
        isEnabled = true;
    }
    public void clickalble()
    {
        if (isEnabled)
        {
            if (mv.currentplayer == movetowards.whichplayer.playerone)
            {
                bat1.slid.value += 15;

                button.SetActive(false);
                isEnabled = false;
            }
            if (mv.currentplayer == movetowards.whichplayer.playertwo)
            {
                // Change the value
                bat2.slid.value += 15;

                // Disable the button
                button.SetActive(false);
                isEnabled = false;
            }


        }
    }

}

*/