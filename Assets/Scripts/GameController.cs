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
    static int score1, score2;
    public Text score1Text, score2Text;
    public int maxScore = 10;
    AudioSource source;
    public AudioClip uwin;

    void Start ()
    {
        source = GetComponent<AudioSource>();
        instance = this;
        winText.text = "";
        score1Text.text = "Игрок 1: " + score1;
        score2Text.text = "Игрок 2: " + score2;

    }
	
    public void Win(int playerNumber)
    {
        if (playerNumber == 1)
        {
            winText.color = Color.red;
            score1++;
        }
        else
        {
            winText.color = Color.blue;
            score2++;
        }
        StartCoroutine(Restart());
        isWin = true;
        if (score1 == maxScore || score2 == maxScore)
        {
             winText.text = "Игрок " + playerNumber + " чемпион";
            score1 = 0;
            score2 = 0;
            source.clip = uwin;
            source.Play();

        }
        else
        {
            winText.text = "Игрок " + playerNumber + " победил";
            source.Play();
        }

    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
