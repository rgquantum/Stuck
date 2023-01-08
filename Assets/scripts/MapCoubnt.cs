using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MapCoubnt : MonoBehaviour
{   

    public static MapCoubnt instance;
    public TextMeshProUGUI text;
    int score;
    public int next;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        next = SceneManager.GetActiveScene().buildIndex + 1;
    }


    void Update()
    {
        if(score >= 15)
       {
        SceneManager.LoadScene(next);
       }
    }

    public void ChangeScore(int mapValue)
    {
        score += mapValue;
        text.text = "X" + score.ToString();
    }



   
}
