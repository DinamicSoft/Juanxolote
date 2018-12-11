using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum estado{
    Menu, Game, pausa, perdedor, ganador
}

public class GameController : MonoBehaviour {
    public estado state;
    public float vidaPlayer;
    public GameController GC;

    private void Awake()
    {
        GC = this;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (state == estado.Menu && Input.GetKeyDown("s"))
        {
            cambiarEstado(estado.Game);
        }
        if (state == estado.Game && Input.GetKeyDown("s"))
        {
            cambiarEstado(estado.pausa);
        }
        if (state == estado.Game && this.vidaPlayer <= 0)
        {
            cambiarEstado(estado.perdedor);
        }
	}

    public void Jugar()
    {
        cambiarEstado(estado.Game);
    }

    private void cambiarEstado(estado gs)
    {
        switch (gs)
        {
            case estado.Menu:

                /*
                 * Codigo de cambio de estados del juego
                 * 
                 */

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
                this.state = gs;
                break;
            case estado.pausa:
                /*
                 * Codigo de cambio de estados del juego
                 * 
                 */
                 this.state = gs;
                break;
            case estado.Game:
                /*
                 * Codigo de cambio de estados del juego
                 * 
                 */
                 this.state = gs;
                break;
            case estado.ganador:
                /*
                 * Codigo de cambio de estados del juego
                 * 
                 */
                 this.state = gs;
                break;
            case estado.perdedor:
                /*
                 * Codigo de cambio de estados del juego
                 * 
                 */
                 this.state = gs;
                break;
        }

    }
}
