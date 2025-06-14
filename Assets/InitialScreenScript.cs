using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InitialScreen : MonoBehaviour
{
    //variables
    public GameObject initialScreen;
    public BirdScript birdScript;        
    public GameObject pipeSpawner;
    public InputField nameInputField;
    public Text alertText;
    public Text userName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //set false the objects that have to appear only when the user
        //provides a name and hits the play button
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
        //pick the name
        string playerName = nameInputField.text.Trim();
        //if there is no user name an alert is sent
        if (string.IsNullOrEmpty(playerName))
        {
            alertText.text = "Type Your Name to Start!";
            return;
        }
        //defines the text of userName object
        userName.text = "Player: " + playerName;

    //starts the objects after hitting the play button
        birdScript.myRigidbody.simulated = true;
        pipeSpawner.SetActive(true);
        alertText.text = "";
        initialScreen.SetActive(false);
    }
}

