using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapCoubnt : MonoBehaviour
{   

    public float mapC;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    void Update()
    {
        if(mapC >= 15)
       {
        SceneManager.LoadScene(2);
       }
    }

    public void MapCounting()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Map")
        {
            Destroy(other.gameObject);
            addMap();
        }
    }

    public void addMap()
    {
        mapC =+1 ;
    }
}
