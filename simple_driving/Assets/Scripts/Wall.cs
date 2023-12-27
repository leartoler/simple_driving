using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private void OnCollisionStay (Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log ("Choque");
        }
    }
}
