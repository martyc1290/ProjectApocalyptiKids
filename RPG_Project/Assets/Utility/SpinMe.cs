using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinMe : MonoBehaviour {

	[SerializeField] float xRotationsPerMinute = 1f;
	[SerializeField] float yRotationsPerMinute = 1f;
	[SerializeField] float zRotationsPerMinute = 1f;
	
	void Update () {
        float xDegreesPerFrame = Time.deltaTime * xRotationsPerMinute * 360 / 60;
        transform.RotateAround (transform.position, transform.right, xDegreesPerFrame);

		float yDegreesPerFrame = Time.deltaTime * yRotationsPerMinute * 360 / 60;
        transform.RotateAround (transform.position, transform.up, yDegreesPerFrame);

        float zDegreesPerFrame = Time.deltaTime * zRotationsPerMinute * 360 / 60;
        transform.RotateAround (transform.position, transform.forward, zDegreesPerFrame);
	}
}
