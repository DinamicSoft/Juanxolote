using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    private int score = 0;
    public Text marcador;
    public Text vida;
    public static ScoreManager scoreM;

    private void Awake()
    {
        scoreM = this;
    }

    public void marcarPuntos(int s)
    {
        score += s;
        marcador.text = "puntos: " + this.score.ToString();
    }

    public void actualizarVida(float v)
    {
        vida.text = "salud " + v;
    }
}
