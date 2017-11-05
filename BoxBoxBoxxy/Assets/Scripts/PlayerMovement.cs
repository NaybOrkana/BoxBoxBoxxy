using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float m_Force = 0f;
	public float m_MovementForce = 0f;
	public bool m_CanIMove = true;
	public bool m_InTitleScreen = true;

	private Rigidbody m_RigidBody;

	private void Start()
	{
		m_RigidBody = GetComponent<Rigidbody> ();
	}

	private void FixedUpdate ()
	{
		Movement ();
	}

	public void Movement()
	{
		if (m_CanIMove) 
		{
			m_RigidBody.AddForce (0, 0, m_Force * Time.deltaTime, ForceMode.Force);

			if (Input.GetButton("Horizontal") || Input.GetButton("HorizontalJ"))
			{
				m_RigidBody.AddForce (m_MovementForce * Time.deltaTime, 0f, 0f, ForceMode.VelocityChange);
			}

			if (Input.GetButton("Horizontal1") || Input.GetButton("HorizontalJL"))
			{
				m_RigidBody.AddForce (-m_MovementForce * Time.deltaTime, 0f, 0f, ForceMode.VelocityChange);
			}


		}

		if (transform.position.y < -1 && !m_InTitleScreen) 
		{
			FindObjectOfType<GameManager> ().EndGame ();
		}
	}


}
