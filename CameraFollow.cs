using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform LookAt; // look at player
    public Vector3 offset = new Vector3(0, 5f, -10f); // keep distance from player

	// Use this for initialization
	void Start ()
    {
        transform.position = LookAt.position + offset;
	}

    // to start follow after player moves 
    private void LateUpdate()
    {
        Vector3 desiredPosition = LookAt.position + offset;

        // donot move in x axis with player
        desiredPosition.x = 0;

        // for smooth movement - get percentage between 2 given value
        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime);
    }
}
