using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DificultdadManager : MonoBehaviour {

    [SerializeField]
    private GameManager managerJuegoPrincipal;
    [SerializeField]
    private int idDificultad;

	public Sacramento[] sacramentos;
	private Sacramento sacramentoActual;
	private static List<Sacramento> sacramentosEscogidos;

	public Pregunta[] preguntas;
	private Pregunta preguntaActual;
	private static List<Pregunta> preguntasSinResponder;

	public static int puntos = 0;
	public static int sacramentosJugados = 0;

    public void dificultElection(int idDificultad)
    {
        if (idDificultad == 0)
        {
            managerJuegoPrincipal.setDificultadEscogida(idDificultad);
			//Modalidad Straight Forward
			sacramentosEscogidos.Add (sacramentos[0]);
			sacramentosEscogidos.Add (sacramentos[1]);
        }
        else if (idDificultad == 1)
        {
            managerJuegoPrincipal.setDificultadEscogida(idDificultad);
			//Modalidad Straight Forward
			sacramentosEscogidos.Add (sacramentos[0]);
			sacramentosEscogidos.Add (sacramentos[1]);
			sacramentosEscogidos.Add (sacramentos[2]);
			sacramentosEscogidos.Add (sacramentos[3]);
        }
        else if (idDificultad == 2)
        {
            managerJuegoPrincipal.setDificultadEscogida(idDificultad);
			//Modalidad Straight Forward
			sacramentosEscogidos.Add (sacramentos[0]);
			sacramentosEscogidos.Add (sacramentos[1]);
			sacramentosEscogidos.Add (sacramentos[2]);
			sacramentosEscogidos.Add (sacramentos[3]);
			sacramentosEscogidos.Add (sacramentos[4]);
			sacramentosEscogidos.Add (sacramentos[5]);
			sacramentosEscogidos.Add (sacramentos[6]);
        }
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
