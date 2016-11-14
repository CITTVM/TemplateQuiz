using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PuntajeManager : MonoBehaviour {

	[SerializeField]
	private float promedio = 0f;

	[SerializeField]
	private DificultdadManager dificultad;

	[SerializeField]
	public Text promedioTxt;

	// Use this for initialization
	void Start () {
		switch (dificultad.getIdDificultad()) {
		case 0:
			promedio = ((dificultad.getPuntos () / 10) * 7) + 1;
			promedioTxt.text = promedio.ToString("0.0");
			break;
		case 1:
			promedio = ((dificultad.getPuntos () / 20) * 7) + 1;
			promedioTxt.text = promedio.ToString("0.0");
			break;
		case 2:
			promedio = ((dificultad.getPuntos () / 35) * 7) + 1;
			promedioTxt.text = promedio.ToString("0.0");
			break;
		default:
			break;
		}
	}
	
	public void volverMenu() {
		SceneManager.LoadScene ("PantallaInicio");
	}
}
