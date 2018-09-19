using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Text winText;
    public static GameController instance;
    public bool isWin; 

	void Start ()
    {
        instance = this;
        winText.text = "";

	}
	
    public void Win(int playerNumber)
    {
        if (playerNumber == 1)
            winText.color = Color.red;
        else
            winText.color = Color.blue;
        winText.text = "Игрок " + playerNumber + " победил";
        StartCoroutine(Restart());
        isWin = true;
    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
