using UnityEngine;
using System.Collections;

public class BossScript : MonoBehaviour {

	// Use this for initialization
	public GameObject player;
	public GameObject musicFin;
	public GameObject musicDeb;
	void Start () {
		player = GameObject.FindGameObjectsWithTag ("Player")[0];
		musicFin = GameObject.FindGameObjectsWithTag ("Finish")[0];
		musicFin.gameObject.audio.Pause();
		musicDeb = GameObject.FindGameObjectsWithTag ("Music")[0];
	}
	
	// Update is called once per frame
	void Update () {
		//player.GetComponent<PlayerScript> ().stopPlayer ();

		if (player.transform.position.x + 24 >= gameObject.transform.position.x) {
			gameObject.GetComponent<EnemyScript> ().onActiveTout ();
			player.GetComponent<PlayerScript> ().stopPlayer ();
			if (musicFin.gameObject.audio.isPlaying)
					musicDeb.gameObject.audio.Play ();
			if (!musicFin.gameObject.audio.isPlaying)
					musicFin.gameObject.audio.Play ();
			musicFin.gameObject.audio.mute = false;
		}
		else {
			gameObject.GetComponent<EnemyScript> ().enPause();
		}
	}

	void OnDestroy() {
		transform.parent.gameObject.AddComponent<LevelEndScript>();
	}
}
