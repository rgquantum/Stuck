using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MapManager : MonoBehaviour
{

    public static MapManager instance;
    public TextMeshProUGUI text;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(score >= 15)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void ChangeScore(int mapValue)
    {
        score += mapValue;
        text.text = "X"+score.ToString();
    }
}
