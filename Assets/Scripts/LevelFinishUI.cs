using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFinishUI : MonoBehaviour
{
	public SreenFader m_Fader;

	public string m_MenuSceneName = "MenuScene";
	public string m_NextLevel = "Level02";

	public void NextLevel()
	{
		Debug.Log ("This will take you to the menu");
		//m_Fader.FadeTo (m_NextLevel);
	}

	public void ToMenu()
	{
		Debug.Log ("This will take you to the next level");
		//m_Fader.FadeTo (m_MenuSceneName);
	}
}
