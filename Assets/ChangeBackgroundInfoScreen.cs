using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeBackgroundInfoScreen : MonoBehaviour
{
    int counter = 0;
    bool flag = false;
    int flagCounter = 0;
    //Text Text;
    // Start is called before the first frame update
    void Start()
    {
       Input.ResetInputAxes();       
       counter = 0;
       //Text.text = "Hi";
    }
    

    // Update is called once per frame
    void Update()
    {
        if(flag){
            if(Input.GetKeyDown(KeyCode.Space)){
                counter++;
            }
            if(counter > 0){
                SceneManager.LoadScene("HeroInfo");
            }            
        }
        else{
            if(flagCounter == 300){
                flag = true;
            }
            flagCounter++;
        }
          
    }

    void ChangeScreen(){
        if(Input.GetKey(KeyCode.Return)){
           SceneManager.LoadScene("HeroInfo");
        }
    }
}
