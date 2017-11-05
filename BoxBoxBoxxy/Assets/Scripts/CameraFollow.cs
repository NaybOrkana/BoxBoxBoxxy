using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour 
{
	public Transform m_TargetPosition;
	public Vector3 m_Offset;

	private void Update () 
	{
		transform.position = m_TargetPosition.position + m_Offset;
	}
}
