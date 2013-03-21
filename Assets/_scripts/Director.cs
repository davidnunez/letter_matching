using UnityEngine;
using System.Collections;

public class Director : MonoBehaviour {
	
	public int numberOfLetters = 10;
	public Letter[] letters;
	public Phoneme phoneme;
	// Use this for initialization
	void Awake () {
		letters = new Letter[numberOfLetters];
		for (int i = 0; i < numberOfLetters; i++) {
			GameObject go = (GameObject)Instantiate (Resources.Load ("_prefabs/LetterPrefab"));	
			Letter letter = go.GetComponent<Letter>();
			letter.Randomize();
			string textureName = "font_sets/" + letter.typeface + "/" + letter.filename();
			
			Texture2D tex = Resources.Load(textureName) as Texture2D;

			go.renderer.material.mainTexture = tex;
			
			Debug.Log (textureName);
			letters[i] = letter;
		}

		GameObject phonemeObject = (GameObject)Instantiate (Resources.Load ("_prefabs/PhonemePrefab"));
		phoneme = phonemeObject.GetComponent<Phoneme>();
	}
	void Start() {
		setupPhoneme();
		phoneme.PlayClip();
	}

	void setupPhoneme(){
		phoneme.setLetter(letters[Random.Range(0, letters.Length)].letter);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	
}
