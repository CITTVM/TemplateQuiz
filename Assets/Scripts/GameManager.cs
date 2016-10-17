using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public Pregunta[] preguntas;
	private Pregunta preguntaActual;
	private static List<Pregunta> preguntasSinResponder;

	[SerializeField]
	private Text textoPregunta;

	[SerializeField]
	private float tiempoEntrePreguntas = 3f;

	[SerializeField]
	private Text textoRespuestaVerdadera;

	[SerializeField]
	private Text textoRespuestaFalsa;

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private AudioSource cheer;
	[SerializeField]
	private AudioSource boo;

	void Start() {

		if (preguntasSinResponder == null || preguntasSinResponder.Count == 0) {
			preguntasSinResponder = preguntas.ToList<Pregunta> ();
		}

		ObtenerPreguntaAleatoria ();

	}

	void ObtenerPreguntaAleatoria() {
		int indicePreguntaAleatorio = Random.Range (0, preguntasSinResponder.Count);
		preguntaActual = preguntasSinResponder [indicePreguntaAleatorio];

		textoPregunta.text = preguntaActual.hecho;

		if (preguntaActual.esVerdad) {
			textoRespuestaVerdadera.text = "CORRECTO";
			textoRespuestaFalsa.text = "INCORRECTO";
		} else {
			textoRespuestaVerdadera.text = "INCORRECTO";
			textoRespuestaFalsa.text = "CORRECTO";
		}
	}

	IEnumerator TransicionEntrePreguntas () {
		preguntasSinResponder.Remove (preguntaActual);

		yield return new WaitForSeconds (tiempoEntrePreguntas);

		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
	}

	public void UsuarioSeleccionaVerdadero () {
		animator.SetTrigger ("Verdadero");
		if (preguntaActual.esVerdad) {
			cheer.Play ();
		} else {
			boo.Play ();
		}
		StartCoroutine (TransicionEntrePreguntas());
	}

	public void UsuarioSeleccionaFalso () {
		animator.SetTrigger ("Falso");
		if (!preguntaActual.esVerdad) {
			cheer.Play ();
		} else {
			boo.Play ();
		}
		StartCoroutine (TransicionEntrePreguntas());
	}
}
