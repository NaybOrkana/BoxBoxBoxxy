using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	public TimeManager m_TimeManager;

	private bool m_CameinContact = false;
	private PlayerMovement m_PlayerMovement;

	private void Start()
	{
		m_PlayerMovement = GetComponent<PlayerMovement> ();
	}

	private void OnCollisionEnter(Collision collisionInfo)
	{
		if (collisionInfo.collider.tag == "Obstacle") 
		{
			m_PlayerMovement.m_CanIMove = false;
			if (m_CameinContact == false) 
			{
				m_TimeManager.SlowdownEffect ();
				m_CameinContact = true;
			}

			FindObjectOfType<GameManager> ().EndGame ();
		}
	}

	private void OnCollisionExit(Collision collisionInfo)
	{
		if (collisionInfo.collider.name == "GroundPlane") 
		{
			m_TimeManager.SlowdownEffect ();
			m_PlayerMovement.m_CanIMove = false;
			if (Input.GetKey(KeyCode.S)) 
			{
				Vector3 savePosition = new Vector3 (0f, 1f, transform.position.z);
				transform.position = savePosition;
				transform.rotation = Quaternion.identity;
			}
		}
	}
}
