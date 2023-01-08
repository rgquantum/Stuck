using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Done : MonoBehaviour
{
   
     public int next;


    void Start()
    {
        next = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextLevel()
    {
        SceneManager.LoadScene(next);
    }



}
