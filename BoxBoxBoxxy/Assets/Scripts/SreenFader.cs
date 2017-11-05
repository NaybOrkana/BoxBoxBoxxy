using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SreenFader : MonoBehaviour
{
	public Image m_Image;
	public AnimationCurve m_AnimationCurve;

	private void Start()
	{
		StartCoroutine (FadeIn ());
	}

	public void FadeTo(string FadeOutToScene)
	{
		StartCoroutine (FadeOut (FadeOutToScene));
	}

	private IEnumerator FadeIn()
	{
		float time = 0.5f;

		while (time > 0f) 
		{
			time -= Time.deltaTime;

			float alpha = m_AnimationCurve.Evaluate (time);

			m_Image.color = new Color (0f, 0f, 0f, alpha);

			yield return 0;
		}
	}

	private IEnumerator FadeOut(string scene)
	{
		float time = 0f;

		while (time < 1f) 
		{
			time += Time.deltaTime;

			float alpha = m_AnimationCurve.Evaluate (time);

			m_Image.color = new Color (0f, 0f, 0f, alpha);

			yield return 0;
		}

		SceneManager.LoadScene (scene);
	}
}
