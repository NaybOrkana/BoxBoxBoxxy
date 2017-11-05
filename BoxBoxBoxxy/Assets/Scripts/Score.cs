using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour 
{
	public Transform m_PlayerPosition;
	public Transform m_Triggerino;

	private float m_LevelLength;

	private Text m_Score;

	private void Start()
	{
		m_Score = GetComponent<Text> ();
		m_LevelLength = m_Triggerino.position.z;
	}

	private	void Update ()
	{
		
		m_Score.text = (m_LevelLength - m_PlayerPosition.position.z).ToString ("0");
	}
}
