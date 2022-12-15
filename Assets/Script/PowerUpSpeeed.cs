using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpeeed : MonoBehaviour
{
   Vector3 velocity;
    public float maxZ;
    public bool active;
    public GameObject paddle;

    private Paddle paddleScript;

    // Start is called before the first frame update
    void Start()
    {
        
            velocity = new Vector3(maxZ, 0, 0); 
            
            paddleScript = paddle.GetComponent<Paddle>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position +=  velocity * Time.deltaTime;
        
    }

 private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Paddle"))
        {
            active = true;
            paddleScript.speed = 60;
            Destroy(gameObject); 
        }
    }

}
