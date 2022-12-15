using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBiggerPaddle : MonoBehaviour
{
    Vector3 velocity;
    public float maxZ;
    public bool active;
    public GameObject paddle;

    // Start is called before the first frame update
    void Start()
    {
        
            velocity = new Vector3(maxZ, 0, 0); 
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position +=  velocity * Time.deltaTime;
        velocity = new Vector3(maxZ, 0, 0);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Paddle"))
        {
            active = true;
            paddle.gameObject.transform.localScale += new Vector3(2,0,0);
            Destroy(gameObject); 
        }

        if (other.CompareTag("WallBottom"))
        {   
            Destroy(gameObject); 
        }
    }

}

