using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public Transform targetObject;
	public float smoothing;

	private Vector3 offset;

	void Start()
	{
		offset = transform.position - targetObject.position;
	}

	void FixedUpdate()
	{
		Vector3 targetCamPos = targetObject.position + offset;
		transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
	}
}
