using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Car : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float speedGainPerSecond = 0.2f;
    [SerializeField] private float turnSpeed = 100f;

    private Rigidbody rb;

    private int steerValue;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    } 


    void Update()
    {
        speed += speedGainPerSecond * Time.deltaTime;
        transform.Rotate(0f, steerValue * turnSpeed * Time.deltaTime, 0f);// <---------- Aqui está el fuckin error!"!!!°!!!!!!!!!!!!"
        rb.velocity = transform.forward * speed * Time.deltaTime;


        transform.Translate(Vector3.forward * speed * Time.deltaTime);   
    }

    //---
    //Para que se detenga el car
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            rb.velocity = Vector3.zero;
        }
        if (collision.gameObject.tag == "Scene_02")
        {
            SceneManager.LoadScene(2);
            Debug.Log("Pasa a nivel 2");

        }



    }



//---
//Esta parte es para que detecte al objeto y se reinicie el juego o se cambie al Scene 0

    /*private void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(0);
        }
    }
*/
//---
    public void Steer (int value)
    {
        steerValue = value;
    }
}
 