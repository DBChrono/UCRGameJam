using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeHeroInformationScreen : MonoBehaviour
{
    int counter = 0;
    bool flag = false;
    int flagCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        Input.ResetInputAxes();
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(flag){
            if(Input.GetKey(KeyCode.Space)){
                counter++;
            }
            if(counter > 0){
                SceneManager.LoadScene("FirstRooom");
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
           SceneManager.LoadScene("FirstRooom");
        }
    }

}
