using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class died : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "obstacle")
        {
            Debug.Log("Died");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
            //Advertisement.Show();
        }
    }      
}
