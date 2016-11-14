using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class DificultdadManager : MonoBehaviour {

    [SerializeField]
    private GameManager managerJuegoPrincipal;

    public static int idDificultad;

	public Sacramento[] sacramentos;
	private static Sacramento sacramentoActual;
	private static List<Sacramento> sacramentosEscogidos;

	public Pregunta[] preguntas;
	private static Pregunta preguntaActual;
	private static List<Pregunta> preguntasSinResponder;

	public static int puntos = 0;
	public static int sacramentosJugados = 0;

	public DificultdadManager () {
		
	}

	void Start() {
		if (sacramentosEscogidos == null || sacramentosEscogidos.Count == 0) {
			sacramentosEscogidos = new List<Sacramento> ();
		}
	}

    public void dificultElection(int idDificultad)
    {
        if (idDificultad == 0)
        {
            //managerJuegoPrincipal.setDificultadEscogida(idDificultad);
			//Modalidad Straight Forward
			sacramentosEscogidos.Add (sacramentos[0]);
			sacramentosEscogidos.Add (sacramentos[1]);
			sacramentoActual = sacramentos [0];
			SceneManager.LoadScene ("PantallaCapsula");
        }
        else if (idDificultad == 1)
        {
            //managerJuegoPrincipal.setDificultadEscogida(idDificultad);
			//Modalidad Straight Forward
			sacramentosEscogidos.Add (sacramentos[0]);
			sacramentosEscogidos.Add (sacramentos[1]);
			sacramentosEscogidos.Add (sacramentos[2]);
			sacramentosEscogidos.Add (sacramentos[3]);
			sacramentoActual = sacramentos [0];
			SceneManager.LoadScene ("PantallaCapsula");
        }
        else if (idDificultad == 2)
        {
            //managerJuegoPrincipal.setDificultadEscogida(idDificultad);
			//Modalidad Straight Forward
			sacramentosEscogidos.Add (sacramentos[0]);
			sacramentosEscogidos.Add (sacramentos[1]);
			sacramentosEscogidos.Add (sacramentos[2]);
			sacramentosEscogidos.Add (sacramentos[3]);
			sacramentosEscogidos.Add (sacramentos[4]);
			sacramentosEscogidos.Add (sacramentos[5]);
			sacramentosEscogidos.Add (sacramentos[6]);
			sacramentoActual = sacramentos [0];
			SceneManager.LoadScene ("PantallaCapsula");
        }
    }

	public Sacramento getSacramentoActual(){
		return sacramentoActual;
	}

	public void setSacramentoActual (Sacramento sacro){
		sacramentoActual = sacro;
	}

	public List<Sacramento> getListaSacramentos(){
		return sacramentosEscogidos;
	}

	public int getIdDificultad (){
		return idDificultad;
	}

	public int getPuntos(){
		return puntos;
	}

	public void armarListasPreguntas () {
		int cantidadPreguntas = 0;

		foreach (var sacramento in sacramentosEscogidos) {
			foreach (var pregunta in preguntas) {
				if (cantidadPreguntas < 5) {
					int indicePreguntaAleatorio = Random.Range (0, preguntas.Length);
					preguntaActual = preguntasSinResponder [indicePreguntaAleatorio];
				} else {
					break;
				}
			}
		}
	}
}
