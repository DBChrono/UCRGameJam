using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeHeroInformationScreen : MonoBehaviour
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
        if(Input.GetKey(KeyCode.Return)){
            counter++;
        }
        if(counter > 0){
           SceneManager.LoadScene("FirstRooom");            
        }
    }

    void ChangeScreen(){
        if(Input.GetKey(KeyCode.Return)){
           SceneManager.LoadScene("FirstRooom");
        }
    }

}
