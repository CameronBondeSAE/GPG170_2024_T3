using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class
public class Rotator : MonoBehaviour
{
	// Variables
	// eg Stats, values for XP, health etc
	// These don't DO anything by themselves
    public Transform myTransform;
    public float speed;

    // Functions/Methods
    // What this component DOES
    // Here's I'm DEFINING a new function
    void FixedUpdate()
    {
	    // Here I'm USING someone elses function
	    myTransform.Rotate(0, speed, 0);
    }
}
