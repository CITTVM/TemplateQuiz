using UnityEngine;
using System.Collections;

public class DificultdadManager : MonoBehaviour {

    [SerializeField]
    private GameManager managerJuegoPrincipal;
    [SerializeField]
    private int idDificultad;

    public void dificultElection(int idDificultad)
    {
        if (idDificultad == 0)
        {
            managerJuegoPrincipal.setDificultadEscogida(idDificultad);
        }
        else if (idDificultad == 1)
        {
            managerJuegoPrincipal.setDificultadEscogida(idDificultad);
        }
        else if (idDificultad == 2)
        {
            managerJuegoPrincipal.setDificultadEscogida(idDificultad);
        }
    }
}
