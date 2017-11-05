using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
	public GameObject m_CompleteLevelUI;
	public SreenFader m_Fader;

	private bool m_GameHasEnded = false;

	public void EndGame()
	{
		if (m_GameHasEnded == false) 
		{
			m_GameHasEnded = true;

			Restart();
		}
	}

	public void LevelComplete()
	{
		m_CompleteLevelUI.SetActive (true);
	}

	private void Restart()
	{
		m_Fader.FadeTo (SceneManager.GetActiveScene ().name);
	}
}
