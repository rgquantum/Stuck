using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spacetonext : MonoBehaviour
{
    // Start is called before the first frame update

    public int next;

    void Start()
    {
        next = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {
       
        {
            
        }
    }

    public void cutScene()
    {
        
        SceneManager.LoadScene(next);
        
    }
        
            
        
    
}
