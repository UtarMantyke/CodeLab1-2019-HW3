using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    public Text ScoreText;
    
    int score = 0;

    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
            print("score now equals:" + score);
            print("I don't understand why the int cannot show on UI text!");
            ScoreText.text = "You would never come back. Even if you tried " + instance.Score +" times.";
        }
    }
    
    public static GameManager instance;
        
    // Start is called before the first frame update
    void Start()
         {
             if (instance == null)
             {
                 DontDestroyOnLoad(gameObject);
                 instance = this;
             }
             else
             {
                 Destroy(gameObject);
             }
         }
    // Update is called once per frame
    void Update()
    {
        
    }
}
