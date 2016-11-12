using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent (typeof (AudioSource))]
public class Capsula : MonoBehaviour {

	[SerializeField]
	private MovieTexture capsula;
	// Use this for initialization
	void Start () {
		GetComponent<RawImage> ().texture = capsula as MovieTexture;
		GetComponent<AudioSource> ().clip = capsula.audioClip;

		capsula.Play ();
		GetComponent<AudioSource>().GetComponent<AudioSource> ().Play ();
	}
}
