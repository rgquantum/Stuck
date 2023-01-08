using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelChoice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Level1()
    {
        SceneManager.LoadScene(3);
    }

    public void Level2()
    {
        SceneManager.LoadScene(5);
    }   

    public void Level3()
    {
        SceneManager.LoadScene(7);

    }

    public void Level4()
    {
        SceneManager.LoadScene(9);

    }

    public void Level5()
    {
        SceneManager.LoadScene(11);

    }

    public void Level6()
    {
        SceneManager.LoadScene(13);
    }

    public void Level7()
    {

    }

    public void Main()
    {
        SceneManager.LoadScene(0);
    }

    public void credit()
    {
        SceneManager.LoadScene(15);
    }
}
