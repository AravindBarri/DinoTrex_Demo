using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatfromDestroy : MonoBehaviour
{
    public GameObject platfromdestroypoint;
    // Start is called before the first frame update
    void Start()
    {
        platfromdestroypoint = GameObject.Find("PlatformDestroyPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < platfromdestroypoint.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
