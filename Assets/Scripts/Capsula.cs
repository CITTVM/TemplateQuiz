﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent (typeof (AudioSource))]
public class Capsula : MonoBehaviour {
	#if UNITY_ANDROID
	[SerializeField]
	private string sacramento1;
	[SerializeField]
	private string sacramento2;
	[SerializeField]
	private string sacramento3;
	[SerializeField]
	private string sacramento4;
	[SerializeField]
	private string sacramento5;
	[SerializeField]
	private string sacramento6;
	[SerializeField]
	private string sacramento7;
	#else
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
	#endif

    [SerializeField]
    private DificultdadManager dificultad;

	[SerializeField]
	private RawImage plano;

	// Use this for initialization
	void Start () {
		DificultdadManager rescateDificultad = dificultad;
		switch (rescateDificultad.getSacramentoActual().getId()) {
		case 0:
			#if UNITY_ANDROID
			Handheld.PlayFullScreenMovie(sacramento1, Color.gray, FullScreenMovieControlMode.Minimal, FullScreenMovieScalingMode.AspectFit);
			#else
			plano.texture = sacramento1 as MovieTexture;
			GetComponent<AudioSource> ().clip = sacramento1.audioClip;

			sacramento1.Play ();
			GetComponent<AudioSource> ().Play ();
			#endif
			break;
		case 1:
			#if UNITY_ANDROID
			Handheld.PlayFullScreenMovie(sacramento2, Color.gray, FullScreenMovieControlMode.Minimal, FullScreenMovieScalingMode.None);
			#else
			plano.texture = sacramento2 as MovieTexture;
			GetComponent<AudioSource> ().clip = sacramento2.audioClip;

			sacramento2.Play ();
			GetComponent<AudioSource> ().Play ();
			#endif
			break;
		case 2:
			#if UNITY_ANDROID
			Handheld.PlayFullScreenMovie(sacramento3, Color.gray, FullScreenMovieControlMode.Minimal, FullScreenMovieScalingMode.None);
			#else
			plano.texture = sacramento3 as MovieTexture;
			GetComponent<AudioSource> ().clip = sacramento3.audioClip;

			sacramento3.Play ();
			GetComponent<AudioSource> ().Play ();
			#endif
			break;
		case 3:
			#if UNITY_ANDROID
			Handheld.PlayFullScreenMovie(sacramento4, Color.gray, FullScreenMovieControlMode.Minimal, FullScreenMovieScalingMode.None);
			#else
			plano.texture = sacramento4 as MovieTexture;
			GetComponent<AudioSource> ().clip = sacramento4.audioClip;

			sacramento4.Play ();
			GetComponent<AudioSource> ().Play ();
			#endif
			break;
		case 4:
			#if UNITY_ANDROID
			Handheld.PlayFullScreenMovie(sacramento5, Color.gray, FullScreenMovieControlMode.Minimal, FullScreenMovieScalingMode.None);
			#else
			plano.texture = sacramento5 as MovieTexture;
			GetComponent<AudioSource> ().clip = sacramento5.audioClip;

			sacramento5.Play ();
			GetComponent<AudioSource> ().Play ();
			#endif
			break;
		case 5:
			#if UNITY_ANDROID
			Handheld.PlayFullScreenMovie(sacramento6, Color.gray, FullScreenMovieControlMode.Minimal, FullScreenMovieScalingMode.None);
			#else
			plano.texture = sacramento6 as MovieTexture;
			GetComponent<AudioSource> ().clip = sacramento6.audioClip;

			sacramento6.Play ();
			GetComponent<AudioSource> ().Play ();
			#endif
			break;
		case 6:
			#if UNITY_ANDROID
			Handheld.PlayFullScreenMovie(sacramento7, Color.gray, FullScreenMovieControlMode.Minimal, FullScreenMovieScalingMode.None);
			#else
			plano.texture = sacramento7 as MovieTexture;
			GetComponent<AudioSource> ().clip = sacramento7.audioClip;

			sacramento7.Play ();
			GetComponent<AudioSource> ().Play ();
			#endif
			break;
		default:
			break;
		}
	}

	public void pasarPreguntas() {
		SceneManager.LoadScene ("PantallaPrincipal");
	}
}
