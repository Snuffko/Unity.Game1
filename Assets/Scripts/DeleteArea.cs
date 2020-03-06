using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteArea : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Coin>() || collision.gameObject.GetComponent<Barrier>())
        {
            Destroy(collision.gameObject);
        }
    }
} 