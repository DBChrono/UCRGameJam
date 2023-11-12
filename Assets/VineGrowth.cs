using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VineGrowth : MonoBehaviour
{
    public GameObject smallVine;
    public GameObject bigVine;

    [SerializeField] private bool isActive;
    public void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            isActive = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision){
        if (collision.CompareTag("Player"))
        {
            isActive = false;
        }
    }

    private void Update()
    {
        if(isActive == true && Input.GetKeyDown(KeyCode.E))
        {
            GrowVine();
        }
    }

    public void GrowVine()
    {
        smallVine.SetActive(false);
        bigVine.SetActive(true);
    }
}
