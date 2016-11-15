using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PuntajeManager : MonoBehaviour {

	[SerializeField]
	private DificultdadManager dificultad;
	[SerializeField]
	public Text promedioTxt;
	[SerializeField]
	private Text detalleTxt;

	// Use this for initialization
	void Start () {
		switch (dificultad.getIdDificultad()) {
		case 0:
			promedioTxt.text = dificultad.getPuntos().ToString() + " de 10";
			if (dificultad.getPuntos() <= 4) {
				detalleTxt.text = "No lo has hecho muy bien, debes estudiar más los sacramentos!!";
			}else if(dificultad.getPuntos() >= 5 && dificultad.getPuntos() <= 7){
				detalleTxt.text = "Tienes algo de conocimiento pero deberías poder hacerlo mejor!!";
			}else if(dificultad.getPuntos() > 7){
				detalleTxt.text = "Muy bien";
			}
			break;
		case 1:
			promedioTxt.text = dificultad.getPuntos().ToString() + " de 20";
			if (dificultad.getPuntos() <= 9) {
				detalleTxt.text = "No lo has hecho muy bien, debes estudiar más los sacramentos!!";
			}else if(dificultad.getPuntos() >= 10 && dificultad.getPuntos() <= 16){
				detalleTxt.text = "Tienes algo de conocimiento pero deberías poder hacerlo mejor!!";
			}else if(dificultad.getPuntos() > 16){
				detalleTxt.text = "Muy bien";
			}
			break;
		case 2:
			promedioTxt.text = dificultad.getPuntos().ToString() + " de 35";
			if (dificultad.getPuntos() <= 17) {
				detalleTxt.text = "No lo has hecho muy bien, debes estudiar más los sacramentos!!";
			}else if(dificultad.getPuntos() >= 18 && dificultad.getPuntos() <= 27){
				detalleTxt.text = "Tienes algo de conocimiento pero deberías poder hacerlo mejor!!";
			}else if(dificultad.getPuntos() > 27){
				detalleTxt.text = "Muy bien";
			}
			break;
		default:
			break;
		}
	}
	
	public void volverMenu() {
		SceneManager.LoadScene ("PantallaInicio");
	}
}
