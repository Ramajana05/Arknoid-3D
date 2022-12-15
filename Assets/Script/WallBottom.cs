using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBottom : MonoBehaviour
{
    public GameObject powerUpBiggerPaddle; 
    public GameObject powerUpSpeedPaddle; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
           Destroy(powerUpBiggerPaddle);
        }
    }
}
