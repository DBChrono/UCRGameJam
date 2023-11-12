using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float x;
    [SerializeField] private float y;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.position = new Vector2(x, y);
        }
    }
}
