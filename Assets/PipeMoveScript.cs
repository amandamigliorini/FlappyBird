using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{

//variables
    public float moveSpeed = 5;
    public float deadZone = -45;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //makes the pipes move
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        //destroy the pipes that hits a x position smaller than the deadZone variable
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
