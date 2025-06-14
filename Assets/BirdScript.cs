using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // variables
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public AudioSource wingSound;
    public AudioSource dieSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //pick the logic object to have access to its functions
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        // the bird flying code. Hitting the space key makes the bird fly higher if the bird is alive
        //a sound is played every time
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
            wingSound.Play();
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //the collision code. If the bird hits a collisor, the pipes, the base and the screen top
        // it dies and game over function is called
        if (birdIsAlive)
        {
            dieSound.Play();
            logic.gameOver();
            birdIsAlive = false;
            Destroy(gameObject, dieSound.clip.length);
        }
    }
}
