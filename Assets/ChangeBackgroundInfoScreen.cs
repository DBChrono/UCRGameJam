using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeBackgroundInfoScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text Text.text = "Hi";
        if(Input.GetKeyDown(KeyCode.Return)){
           SceneManager.LoadScene("HeroInfo");
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return)){
           SceneManager.LoadScene("HeroInfo");
        }

    }
}
