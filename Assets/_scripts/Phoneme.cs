using UnityEngine;
using System.Collections;

public class Phoneme : MonoBehaviour {
	public static string[] VOICES = new string[] {"filip_dirty_test"}; // TODO: this could probably go elsewhere 
	public string letter;
	public string voice;
	// Use this for initialization
	void Start () {
		voice = VOICES[0];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void filename() {
		return letter;
	}
}
