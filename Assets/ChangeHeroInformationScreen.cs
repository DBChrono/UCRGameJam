using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeHeroInformationScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(Input.GetKeyDown(KeyCode.Return)){
           SceneManager.LoadScene("FirstRooom");
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return)){
           SceneManager.LoadScene("FirstRooom");
        }
                
    }
}
