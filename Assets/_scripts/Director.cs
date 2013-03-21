using UnityEngine;
using System.Collections;

public class Director : MonoBehaviour {
	
	public int numberOfLetters = 10;
	
	// Use this for initialization
	void OnEnable () {
	
		for (int i = 0; i < numberOfLetters; i++) {
			GameObject go = (GameObject)Instantiate (Resources.Load ("_prefabs/LetterPrefab"));	
			Letter letter = go.GetComponent<Letter>();
			letter.Randomize();
			string textureName = "font_sets/" + letter.typeface + "/" + letter.filename();
			
			Texture2D tex = Resources.Load(textureName) as Texture2D;

			go.renderer.material.mainTexture = tex;
			
			Debug.Log (textureName);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
