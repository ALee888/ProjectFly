using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    void OnCollisionEnter(Collision other) 
    {
        Debug.Log("collision");
        if (other.gameObject.tag != "Player")
        {
            if (other.gameObject.tag == "Enemy")
            {
                Debug.Log("hit");
                Destroy(other.gameObject);
            }
            Destroy(gameObject);
        }
    }
}
