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
    public float Powavite = 2;


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
            coutame1 = coutame1 *2;
            texteAme1.text = "Deplumeur m�canique " + lvlame1 +"." + " Prochain niveau dans " + coutame1 + " plumes.";
            Powavite -= 0.3f;
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
            yield return new WaitForSeconds(Powavite);
        }
        
        
        
    }
}
