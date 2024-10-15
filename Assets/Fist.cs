using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fist : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
	    other.GetComponent<Health>().Damage(1000000f);
    }
}
