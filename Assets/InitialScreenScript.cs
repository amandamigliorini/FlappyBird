using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InitialScreen : MonoBehaviour
{
    public GameObject initialScreen;
    public BirdScript birdScript;        
    public GameObject pipeSpawner;
    public InputField nameInputField;
    public Text alertText;
    public Text userName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        birdScript.myRigidbody.simulated = false;
        pipeSpawner.SetActive(false);
        initialScreen.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartGame()
    {
        
        string playerName = nameInputField.text.Trim();

        if (string.IsNullOrEmpty(playerName))
        {
            alertText.text = "Type Your Name to Start!";
            return;
        }

        userName.text = "Player: " + playerName;


        birdScript.myRigidbody.simulated = true;
        pipeSpawner.SetActive(true);
        alertText.text = "";
        initialScreen.SetActive(false);
    }
}

