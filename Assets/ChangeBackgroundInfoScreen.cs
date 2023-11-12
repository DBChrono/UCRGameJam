using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeBackgroundInfoScreen : MonoBehaviour
{
    int counter = 0;
    //Text Text;
    // Start is called before the first frame update
    void Start()
    {
       counter = 0;
       //Text.text = "Hi";
    }
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Return)){
            counter++;
        }
        if(counter > 0){
           SceneManager.LoadScene("HeroInfo");            
        }

    }

    void ChangeScreen(){
        if(Input.GetKey(KeyCode.Return)){
           SceneManager.LoadScene("HeroInfo");
        }
    }
}
