[System.Serializable]
public class Sacramento {
	public string nombre;
	public int id;
	public int restantes;

	public int getId(){
		return id;
	}

	public int getRestantes(){
		return restantes;
	}

	public void setRestantes(int restante){
		restantes = restante;
	}
}
