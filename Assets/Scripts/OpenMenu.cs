using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Info1;
    public GameObject Info2;
    public GameObject Info3;
    public GameObject Ame1;
    public GameObject Ame2;
    public GameObject Ame3;
    public GameObject Enti1;
    public GameObject Enti2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        Menu.SetActive(true);
        Menu.SetActive(false);

    }
}
