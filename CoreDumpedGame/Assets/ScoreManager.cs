using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int score;        // The player's scor

    public int counterInit;
    int counter;

    public Text text;                      // Reference to the Text component.


    void Awake()
    {
        // Set up the reference.

        // Reset the score.
        score = 0;

        counter = counterInit;
    }


    void Update()
    {
        if (!PauseMenu.GameIsPaused)
        {
            counter--;
        }
        if (counter == 0)
        {
            score++;
            counter = counterInit;
        }
        // Set the displayed text to be the word "Score" followed by the score value.
        text.text = "Score: " + score;
    }
}