using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	
	public void BotonStart () {
        SceneManager.LoadScene("HistoriaUno");
	}

    public void BotonQuit()
    {
        Debug.Log("Se cierra el juego");
        Application.Quit();
    }

    public void LoadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
    
}
