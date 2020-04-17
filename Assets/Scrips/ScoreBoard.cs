using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//To modify UI and text we need to add this line bellow (name space)
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{


    // No need to put "= 0" for an int, because by defaut they start at zero
    int score;
    //This variable represent the all component
    Text scoreText;


    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        //".text" represent the text element in the Text gameObject
        //To make appear an int in a string, we can type ".ToString" behind the int
        scoreText.text = score.ToString();
        
    }

    public void ScoreHit(int scoreIncrease)
    {
        score = score + scoreIncrease;
        scoreText.text = score.ToString();
    }
}
