using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VineClimbing : MonoBehaviour
{

    private float vertical;
    private float speed = 8f;
    public bool isVine;
    private bool isClimbing;

    [SerializeField] private Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        if(isVine && Mathf.Abs(vertical) > 0f){
            isClimbing = true;
        }
    }

    private void FixedUpdate(){
        if(isClimbing){
            rb.gravityScale = 0f;
            rb.velocity = new Vector2(rb.velocity.x, vertical * speed);
        }
        else{
            rb.gravityScale = 2f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("BigVine")){
            isVine = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision){
        if(collision.CompareTag("BigVine")){
            isVine = false;
            isClimbing = false;
        }
    }
}
