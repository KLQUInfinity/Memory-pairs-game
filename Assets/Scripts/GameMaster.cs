using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour
{
	private static GameMaster instance;

	public static GameMaster Instance{ get { return instance; } }

	private void Awake ()
	{
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (gameObject);
		} else if (instance != this) {
			Destroy (gameObject);
		}
	}
}
