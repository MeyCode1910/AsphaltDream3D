using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayScript : MonoBehaviour
{
   
    public Transform[] roads;


   private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Respawn")
        {
            roads[0].localPosition += new Vector3(0, 0, roads[0].localScale.z * 20f);
            roads[1].localPosition += new Vector3(0, 0, roads[0].localScale.z * 20f);
            roads[2].localPosition += new Vector3(0, 0, roads[0].localScale.z *20f);
            roads[3].localPosition += new Vector3(0, 0, roads[0].localScale.z *20f);
            roads[4].localPosition += new Vector3(0, 0, roads[0].localScale.z *20f);
            roads[5].localPosition += new Vector3(0, 0, roads[0].localScale.z *20f);
            roads[6].localPosition += new Vector3(0, 0, roads[0].localScale.z *20f);
            roads[7].localPosition += new Vector3(0, 0, roads[0].localScale.z *20f);
            roads[8].localPosition += new Vector3(0, 0, roads[0].localScale.z *20f);
            roads[9].localPosition += new Vector3(0, 0, roads[0].localScale.z *20f);

            Array.Reverse(roads);
        }
    }

}
