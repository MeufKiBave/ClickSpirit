using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LvlAme1 : MonoBehaviour
{

    public ScoreManager scoreGagne;

    public TextMeshProUGUI scoreText;

    public TextMeshProUGUI texteAme1;

    public int lvlame1 = 0;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void lvlupAme1()
    {
        if (scoreGagne.score >= 5)
        {
            scoreGagne.score -= 5;
            lvlame1++;
            texteAme1.text = "Amelioration 1 a " + lvlame1;

            //Debug.Log("lvlup1");
        }
        if (scoreGagne.score >= 10)
        {
            scoreGagne.score -= 10;
            lvlame1++;
            texteAme1.text = "Amelioration 1 a " + lvlame1;
        }
    }
}
