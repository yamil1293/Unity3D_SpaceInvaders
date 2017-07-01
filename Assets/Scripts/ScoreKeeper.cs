using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

	public static float speed;
	public float startingSpeed = 2.5f;
	public static int score = 0;
	private static int highScore = 0;
	public static bool gameOver = false;

	// Use this for initialization
	void Start ()
	{
		speed = startingSpeed;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (score > highScore) 
		{
			highScore = score;
		}
		if (gameOver)
		{
			if (Input.GetKeyDown(KeyCode.Z))
			{
				gameOver = false;
				score = 0;
				Application.LoadLevel("MainGame");
			}
		}
	}

	void OnGUI ()
	{
		GUI.Label (new Rect (0, 0, 120, 20),"Score: " + score.ToString());
		GUI.Label (new Rect (0, 20, 120, 20),"Hi Score: " + highScore.ToString());

		if (gameOver)
		{
			GUI.Label (new Rect (Screen.width / 2.0f - 50, Screen.height / 2.0f, 120, 20), "GAME OVER");
		}
	}
}
