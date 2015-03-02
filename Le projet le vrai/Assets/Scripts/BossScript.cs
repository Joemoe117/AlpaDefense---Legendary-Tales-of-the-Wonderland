using UnityEngine;
using System.Collections;

public class BossScript : MonoBehaviour {

	// Use this for initialization
	public GameObject player;
	void Start () {
		player = GameObject.FindGameObjectsWithTag ("Player")[0];



	}
	
	// Update is called once per frame
	void Update () {
		//player.GetComponent<PlayerScript> ().stopPlayer ();

		if (player.transform.position.x + 25 >= gameObject.transform.position.x)
			player.GetComponent<PlayerScript> ().stopPlayer ();
	}

	void OnDestroy() {
		transform.parent.gameObject.AddComponent<LevelEndScript>();
	}
}
