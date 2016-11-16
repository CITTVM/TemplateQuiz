using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class InicioManager : MonoBehaviour {
	public void IniciarPartida(){
		SceneManager.LoadScene ("PantallaDificultad");
	}
}
