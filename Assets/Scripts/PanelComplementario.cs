using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelComplementario : MonoBehaviour
{
	public GameObject panelComplementario;
	public Game game;

	public void Continuar() 
	{
		panelComplementario.SetActive(false);
		game.setPregunta();
	}

	public void Desplegar() 
	{
		panelComplementario.SetActive(true);
	}

}
