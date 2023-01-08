using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class victoryscreen1 : MonoBehaviour
{
    // Start is called before the first frame update

    public int next;
    public int prev;

    void Start()
    {
        next = SceneManager.GetActiveScene().buildIndex + 1;
        prev = SceneManager.GetActiveScene().buildIndex - 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextLevel()
    {
        SceneManager.LoadScene(next);
    }

    public void retryLevel()
    {
        SceneManager.LoadScene(prev);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }


}
