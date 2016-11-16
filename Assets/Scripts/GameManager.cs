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

	public static int puntos = 0;

	[SerializeField]
	private static int dificultadEscogida;//Dificultad de la instancia de juego.

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

	[SerializeField]
	private DificultdadManager dificultad;

	public GameManager () {
		
	}

	void Start() {

		if (preguntasSinResponder == null || preguntasSinResponder.Count == 0) {
			//preguntasSinResponder = preguntas.ToList<Pregunta> ();
			preguntasSinResponder = shuffle(preguntas).ToList<Pregunta> ();
		}

		ObtenerPreguntaAleatoria ();

	}

	void ObtenerPreguntaAleatoria() {
		if (dificultad.getListaSacramentos().Count == 0) {
			preguntasSinResponder = null;
			SceneManager.LoadScene ("PantallaPuntaje");
		}
		if (dificultad.getSacramentoActual().getRestantes() == 0 && dificultad.getListaSacramentos().Count != 0) {
			dificultad.getListaSacramentos ().Remove (dificultad.getSacramentoActual());
			dificultad.setSacramentoActual (dificultad.getListaSacramentos().FirstOrDefault());
			SceneManager.LoadScene ("PantallaCapsula");
		}
			
		foreach (var pregunta in preguntasSinResponder) {
			if (dificultad.getSacramentoActual().getId() == pregunta.getIdSacramento()) {
				//int indicePreguntaAleatorio = Random.Range (0, preguntasSinResponder.Count);
				//preguntaActual = preguntasSinResponder [indicePreguntaAleatorio];
				preguntaActual = pregunta;
				break;
			}
		}

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
		dificultad.getSacramentoActual ().setRestantes (dificultad.getSacramentoActual().getRestantes() - 1);
		yield return new WaitForSeconds (tiempoEntrePreguntas);

		SceneManager.LoadScene ("PantallaPrincipal");
	}

	public void UsuarioSeleccionaVerdadero () {
		animator.SetTrigger ("Verdadero");
		if (preguntaActual.esVerdad) {
			cheer.Play ();
			//puntos++;
			dificultad.aumentarPuntos();
		} else {
			boo.Play ();
		}
		StartCoroutine (TransicionEntrePreguntas());
	}

	public void UsuarioSeleccionaFalso () {
		animator.SetTrigger ("Falso");
		if (!preguntaActual.esVerdad) {
			cheer.Play ();
			//puntos++;
			dificultad.aumentarPuntos();
		} else {
			boo.Play ();
		}
		StartCoroutine (TransicionEntrePreguntas());
	}

	/**public void ObtenerSacramentoAleatorio () {
		int indiceSacramentoAleatorio = Random.Range (0, sacramentosEscogidos.Count);
		sacramentoActual = sacramentosEscogidos [indiceSacramentoAleatorio];
	}

	public void sacarPreguntas () {
		Sacramento sacramentoElegido = sacramentosEscogidos.FirstOrDefault ();
		sacramentosEscogidos.Remove (sacramentoElegido);
	}*/

    public void setDificultadEscogida(int id)
    {
        dificultadEscogida = id;
    }

	Pregunta[] shuffle(Pregunta[] preguntas)
	{
		// Knuth shuffle algorithm
		for (int t = 0; t < preguntas.Length; t++ )
		{
			Pregunta tmp = preguntas[t];
			int r = Random.Range(t, preguntas.Length);
			preguntas[t] = preguntas[r];
			preguntas[r] = tmp;
		}
		return preguntas;
	}
}
