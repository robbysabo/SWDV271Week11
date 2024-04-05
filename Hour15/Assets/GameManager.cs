using UnityEngine;
using UnityEngine.UI; // Note this new line is needed for UI
using TMPro;
public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    int playerScore = 0;
    public void AddScore()
    {
        playerScore++;
        // This converts the score (a number) into a string
        scoreText.text = AddExtraZeros();
    }
    public void PlayerDied()
    {
        gameOverText.enabled = true;
        // This freezes the game
        Time.timeScale = 0;
    }

    private string AddExtraZeros()
    {
        string newText = playerScore.ToString();
        int len = newText.Length;
        while (len < 10)
        {
            newText = "0" + newText;
            len = newText.Length;
        }
        return newText;
    }
}