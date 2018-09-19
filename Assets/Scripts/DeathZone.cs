using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public int playerNumber = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (!GameController.instance.isWin)
        {
            Debug.Log("PLAYER" + playerNumber + " LOSE!");
            GameController.instance.Win(playerNumber);
        }


    }
}
