using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //pick the logic object to have access to its functions
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //calls the addScore function when the bird collides with the collisor added between the pipes
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(1);
        }
        
    }
}
