using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeIntroScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.UnloadSceneAsync("BackgroundInfo");
        SceneManager.UnloadSceneAsync("HeroInfo");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Return)){
            SceneManager.LoadScene("BackgroundInfo");
        }
          
    }

    void ChangeScreen(){
        if(Input.GetKey(KeyCode.Return)){
           SceneManager.LoadScene("BackgroundInfo");
        }
    }    
}
