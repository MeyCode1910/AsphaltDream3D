using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ArabaSpawn : MonoBehaviour
{

    private float varsayilan_hiz;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
       
        varsayilan_hiz = Random.Range(12.5f, 15.5f);
        
     
    }
        void Update()
        {
            rb.velocity = new Vector3(rb.velocity.x, 0, varsayilan_hiz * 40 * Time.deltaTime);
        }
    
}


