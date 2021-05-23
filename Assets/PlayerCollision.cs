using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        //print(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("Player"))
        {
            print("Game Over");
            print("Your Score is" + transform.position.x); //prints final score in console
            Destroy(collision.gameObject, 0); //destroy the player object when colide with obstacle
            SceneManager.LoadScene(2); //loads GameOver Scene
        }

    }
}
