using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int hitCount;
    public Material[] materials;
    public bool breakable;

    public GameObject powerUpBiggerPaddle; 
    public GameObject powerUpSpeedPaddle; 

    Vector3 currentBlockPosition;



    public void destroyYourself()
    {
        GetComponent<Renderer>().material = materials[hitCount];
        currentBlockPosition = gameObject.transform.position;
        Destroy(gameObject);

        //currentBlockPosition = powerUpSpeedPaddle.transform.SetPositionAndRotation
    }

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Renderer>().material = GameManager.Instance.defaultMaterial;
        //hitCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
