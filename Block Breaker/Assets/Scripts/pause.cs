using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
	public static bool GameIsPaused = false;

	void Start()
	{
		Time.timeScale = 0f;
		GameIsPaused = true;
	}
	void Update()
	{
		
			if (!GameIsPaused)
			{
				Pause();
			}
		
	}


	public void Resume()
	{
		Time.timeScale = 1f;
		GameIsPaused = false;

	}
	public void Pause()
	{

		Time.timeScale = 0f;
		GameIsPaused = true;

	}


}
