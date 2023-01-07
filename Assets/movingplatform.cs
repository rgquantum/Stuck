using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingplatform : MonoBehaviour
{
    // Start is called before the first frame update


    public bool up;
    

    void Start()
    {
        up=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(up == true)
        {
            this.gameObject.transform.Translate(new Vector3(0, 5 * Time.deltaTime, 0));
        }
        
        if(up == false)
        {
            this.gameObject.transform.Translate(new Vector3(0, -5 * Time.deltaTime, 0));
        }
    }

    private void FixedUpdate() {
       
    }



    private void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.tag == "Stopping")
        {
            up = true;
            Debug.Log("up");
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "downing")
        {
            up = false;
            Debug.Log("Down");
        }
    
    }

    
}
