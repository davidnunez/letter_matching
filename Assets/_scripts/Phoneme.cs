using UnityEngine;
using System.Collections;

public class Phoneme : MonoBehaviour {
	public static string[] VOICES = new string[] {"filip_dirty_test"}; // TODO: this could probably go elsewhere 
	public string letter;
	public string voice;
	public AudioSource audioSource;
	public AudioClip audioClip;

	// Use this for initialization
	void Awake () {
		voice = VOICES[0];
		audioSource = Camera.mainCamera.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	string filename() {
		return letter;
	}
	
	public void setLetter(string l) {
		letter = l;
		audioClip = Resources.Load(voice + "/" + filename()) as AudioClip;
		Debug.Log ("Setting phoneme mp3 to:" + voice +"/" +filename());
	}
	public void PlayClip() {
		audioSource.PlayOneShot(audioClip);
	}

}
