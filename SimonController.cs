using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class SimonController : MonoBehaviour {

	public bool enableInput = false;

	public float stepPlaybackTime = .5f;


	public Button[] InputButtons;
	public AudioSource[] buttonAudioSources;
	public UnityEngine.UI.Image[] buttonBaseSprites;
	public UnityEngine.UI.Image[] buttonHighlightSprites;

	public List<Color> colorPallets;

	public AudioSource WrongBuzzer;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	public void CompareInput(int playerInput){

	}

}
