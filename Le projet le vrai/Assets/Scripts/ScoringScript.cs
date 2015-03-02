using UnityEngine;
using System.Collections;

public class ScoringScript : MonoBehaviour {

	// Use this for initialization
	public static ScoringScript Instance;
	private int score = 0;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int getScore(){
		return score;
	}

	public void setScore(int newScore){
		score = newScore;
	}

	public void upScore(int gain){
		score += gain;
		Debug.Log (score);
	}
}
