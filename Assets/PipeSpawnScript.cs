using JetBrains.Annotations;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    //variables and objects

    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heigthOffset = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //calls the function that creates and moves the pipes
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        //set a timer to have the pipes created eriodically
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            //calls the function to create the pies and reset the timer
            spawnPipe();
            timer = 0;
        }
            
    }
    
    void spawnPipe()
    {
        //function to create the pipes and move it through the screen
        //the pipes have a lowest point and highestPoint to be set and then the pipes position becomes random
        float lowestPoint = transform.position.y - heigthOffset;
        float highestPoint = transform.position.y + heigthOffset; 
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
