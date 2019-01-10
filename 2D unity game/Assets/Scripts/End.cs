using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    public int num;

    // Use this for initialization
    void Update()
        //changes back to menu on key press
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Menu");
            Debug.Log("Scene changed to " + num);
        }
    }
}
