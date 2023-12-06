using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LvlAme2 : MonoBehaviour
{

    public ScoreManager scoreGagne;

    public TextMeshProUGUI scoreText;

    public TextMeshProUGUI texteAme2;

    public int lvlame2 = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void lvlupAme2()
    {
        if (scoreGagne.score >= 5)
        {
            scoreGagne.score -= 5;
            lvlame2++;
            texteAme2.text = "Amelioration 2 a " + lvlame2;

            Debug.Log("lvlup");
        }
        if (scoreGagne.score >= 10)
        {
            scoreGagne.score -= 10;
            lvlame2++;
            texteAme2.text = "Amelioration 2 a " + lvlame2;
        }
    }
}
