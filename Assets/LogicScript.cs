using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource pointSound;


    public void addScore(int scoreToAdd)
    {
        //increase the score by the value set on the game
        //plays a sound every time
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        pointSound.Play();
    }

    public void restartGame()
    {
        // restart the scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        //shows the game over screen 
        gameOverScreen.SetActive(true);
    }
}
