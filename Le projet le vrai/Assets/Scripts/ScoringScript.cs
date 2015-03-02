using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoringScript : MonoBehaviour {

	// Use this for initialization
	public static ScoringScript Instance;
	private int score = 0;
	public GameObject playerScore;

	void Start () {
		playerScore = GameObject.FindGameObjectsWithTag ("Point") [0];
		playerScore.GetComponent<Text> ().text = "Point : " + score.ToString();
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
		playerScore.GetComponent<Text> ().text = "Point : " + score.ToString();
	}
}
