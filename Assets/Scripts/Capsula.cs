using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent (typeof (AudioSource))]
public class Capsula : MonoBehaviour {
	[SerializeField]
	private MovieTexture sacramento1;
	[SerializeField]
	private MovieTexture sacramento2;
	[SerializeField]
	private MovieTexture sacramento3;
	[SerializeField]
	private MovieTexture sacramento4;
	[SerializeField]
	private MovieTexture sacramento5;
	[SerializeField]
	private MovieTexture sacramento6;
	[SerializeField]
	private MovieTexture sacramento7;

    [SerializeField]
    private DificultdadManager dificultad;

	[SerializeField]
	private RawImage plano;

	// Use this for initialization
	void Start () {
		DificultdadManager rescateDificultad = dificultad;
		switch (rescateDificultad.getSacramentoActual().getId()) {
		case 0:
			//GetComponent<RawImage> ().texture = sacramento1 as MovieTexture;
			//GetComponent<AudioSource> ().clip = sacramento1.audioClip;
			plano.texture = sacramento1 as MovieTexture;
			GetComponent<AudioSource> ().clip = sacramento1.audioClip;

			sacramento1.Play ();
			GetComponent<AudioSource> ().Play ();
			break;
		case 1:
			//GetComponent<RawImage> ().texture = sacramento2 as MovieTexture;
			//GetComponent<AudioSource> ().clip = sacramento2.audioClip;
			plano.texture = sacramento2 as MovieTexture;
			GetComponent<AudioSource> ().clip = sacramento2.audioClip;

			sacramento2.Play ();
			GetComponent<AudioSource> ().Play ();
			break;
		case 2:
			//GetComponent<RawImage> ().texture = sacramento3 as MovieTexture;
			//GetComponent<AudioSource> ().clip = sacramento3.audioClip;
			plano.texture = sacramento3 as MovieTexture;
			GetComponent<AudioSource> ().clip = sacramento3.audioClip;

			sacramento3.Play ();
			GetComponent<AudioSource> ().Play ();
			break;
		case 3:
			//GetComponent<RawImage> ().texture = sacramento4 as MovieTexture;
			//GetComponent<AudioSource> ().clip = sacramento4.audioClip;
			plano.texture = sacramento4 as MovieTexture;
			GetComponent<AudioSource> ().clip = sacramento4.audioClip;

			sacramento4.Play ();
			GetComponent<AudioSource> ().Play ();
			break;
		case 4:
			//GetComponent<RawImage> ().texture = sacramento5 as MovieTexture;
			//GetComponent<AudioSource> ().clip = sacramento5.audioClip;
			plano.texture = sacramento5 as MovieTexture;
			GetComponent<AudioSource> ().clip = sacramento5.audioClip;

			sacramento5.Play ();
			GetComponent<AudioSource> ().Play ();
			break;
		case 5:
			//GetComponent<RawImage> ().texture = sacramento6 as MovieTexture;
			//GetComponent<AudioSource> ().clip = sacramento6.audioClip;
			plano.texture = sacramento6 as MovieTexture;
			GetComponent<AudioSource> ().clip = sacramento6.audioClip;

			sacramento6.Play ();
			GetComponent<AudioSource> ().Play ();
			break;
		case 6:
			//GetComponent<RawImage> ().texture = sacramento7 as MovieTexture;
			//GetComponent<AudioSource> ().clip = sacramento7.audioClip;
			plano.texture = sacramento7 as MovieTexture;
			GetComponent<AudioSource> ().clip = sacramento7.audioClip;

			sacramento7.Play ();
			GetComponent<AudioSource> ().Play ();
			break;
		default:
			break;
		}
	}

	public void pasarPreguntas() {
		SceneManager.LoadScene ("PantallaPrincipal");
	}
}
