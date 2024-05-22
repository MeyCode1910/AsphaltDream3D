using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public WheelCollider ArkaSag, ArkaSol;
    public float speedCar, frenGucu;
    public bool GazaBasiliyor, FreneBasiliyor;
    public float speed, MaxSpeed;
    public Rigidbody rb;
  
    float speeddddd = 30f;
    void Update()
    {
        speed = rb.velocity.sqrMagnitude;
        if (speed < MaxSpeed)
        {


            if (GazaBasiliyor)
            {
                ArkaSag.brakeTorque = 0;
                ArkaSol.brakeTorque = 0;
                ArkaSag.motorTorque = speedCar + 0.5f;
                ArkaSol.motorTorque = speedCar + 0.5f;
            }
        }
        else
        {
            ArkaSag.brakeTorque = frenGucu;
            ArkaSol.brakeTorque = frenGucu;
        }

        if (FreneBasiliyor)
        {
            ArkaSag.brakeTorque = frenGucu;
            ArkaSol.brakeTorque = frenGucu;
        }

        Vector3 dir = Vector3.zero;
        dir.x = Input.acceleration.x;
        //  dir.z = Input.acceleration.x;

        if (dir.sqrMagnitude > 1)
            dir.Normalize();

        dir *= Time.deltaTime;
        transform.Translate(dir * speeddddd);


        // Player'ýn sabit hýzda ileriye doðru hareket etmesi
        MovePlayerForward();
    }

    void MovePlayerForward()
    {
        // Player'ýn belirli bir hýzda ileriye doðru hareket etmesi
        transform.Translate(Vector3.forward * 10 * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene(1);
        }
    }

    public void FrenDown()
    {
        FreneBasiliyor = true;
    }
    public void FrenExit()
    {
        FreneBasiliyor = false;
    }
    public void GazDown()
    {
        GazaBasiliyor = true;
    }
    public void GazExit()
    {
        GazaBasiliyor = false;
    }


}       
