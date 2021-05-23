using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    public GameObject platformprefab; //platform prefab
    public GameObject enemyprefab; //enemy prefab
    public Transform GenerationPoint; //the point of the ground generation
    public float distanceplatform; //variable to store the distance between the platforms

    private float platformwidth; //used to store the platform width
    //private Rigidbody playerbody;
    // Start is called before the first frame update
    void Start()
    {
        platformwidth = platformprefab.GetComponent<BoxCollider>().size.x; //get the ground size in x axis
        //playerbody = GetComponent<Rigidbody>(); //gets the player rigid body component
    }

    // Update is called once per frame
    void Update()
    {
        int x = Random.Range(-4, 5); //gives a random range for obstacle generation
        if (transform.position.x < GenerationPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + platformwidth + distanceplatform, transform.position.y, transform.position.z); //next platform spawn location
            Instantiate(platformprefab, transform.position, Quaternion.identity); //instantiate the ground
            Instantiate(enemyprefab, transform.position + new Vector3(x,0.3f,0), Quaternion.identity); //instantiate the enemy obstacle at random x position on ground
        }
    }
}
