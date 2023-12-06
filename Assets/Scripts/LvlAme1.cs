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
    public int coutame1 = 10;
    public int power1 = 1;
    public float powerspeed = 0.8f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PowerSpeed());
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void lvlupAme1()
    {
        if (scoreGagne.score >= coutame1)
        {
            scoreGagne.score -= coutame1;
            lvlame1++;
            scoreGagne.score = power1;
            coutame1 = coutame1 *2;
            texteAme1.text = "Cimetiere " + lvlame1 + " Level 2 dans " + coutame1 + " d'ames.";

            //Debug.Log("lvlup1");
        }
    }
    public IEnumerator PowerSpeed()
    {
        while (true)
        {
            if (lvlame1 > 0)
            {
                Debug.Log("jepassdanslacoroytine");
                scoreGagne.RiseScore(1);
            }
            yield return new WaitForSeconds(2);
        }
        
        
        
    }
}
