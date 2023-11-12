using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeIntroScreen : MonoBehaviour
{
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
            counter++;
        }
        if(counter > 0){
           SceneManager.LoadScene("BackgroundInfo");
        }
          
    }

    void ChangeScreen(){
        if(Input.GetKey(KeyCode.Return)){
           SceneManager.LoadScene("BackgroundInfo");
        }
    }    
}
