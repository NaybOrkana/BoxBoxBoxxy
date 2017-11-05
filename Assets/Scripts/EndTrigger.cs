using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour 
{
	public GameManager m_Manager;

	private void OnTriggerEnter()
	{
		m_Manager.LevelComplete ();
	}

}
