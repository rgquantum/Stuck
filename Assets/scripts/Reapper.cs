using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reapper : MonoBehaviour
{

    public bool disabled = false;
    // Start is called before the first frame update
    void Start()
    {
        foreach(Transform child in gameObject.transform)
        {
            child.gameObject.SetActive(disabled);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player")
        {
            onPlatform();
        }
    }

    void onPlatform()
    {
        
        foreach(Transform child in gameObject.transform)
        {
            child.gameObject.SetActive(!disabled);
        }
    }
}
