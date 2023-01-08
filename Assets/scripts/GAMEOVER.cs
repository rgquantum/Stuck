using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GAMEOVER : MonoBehaviour
{
    // Start is called before the first frame update

    private int lastScene;

    void Start()
    {
        lastScene = SceneManager.GetActiveScene().buildIndex - 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RetryGame()
    {
        SceneManager.LoadScene(lastScene);
    }
}
