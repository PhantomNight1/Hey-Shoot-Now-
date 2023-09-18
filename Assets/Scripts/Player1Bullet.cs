using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Bullet : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player2")
        {
            Destroy(this.gameObject);
        }
    }
}
