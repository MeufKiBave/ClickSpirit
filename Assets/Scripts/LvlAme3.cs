using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LvlAme3 : MonoBehaviour
{

    public ScoreManager scoreGagne;

    public TextMeshProUGUI scoreText;

    public TextMeshProUGUI texteAme3;

    public int lvlame3 = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void lvlupAme3()
    {
        if (scoreGagne.score >= 5)
        {
            scoreGagne.score -= 5;
            lvlame3++;
            texteAme3.text = "Amelioration 3 a " + lvlame3;

            Debug.Log("lvlup");
        }
        if (scoreGagne.score >= 10)
        {
            scoreGagne.score -= 10;
            lvlame3++;
            texteAme3.text = "Amelioration 3 a " + lvlame3;
        }
    }
}
