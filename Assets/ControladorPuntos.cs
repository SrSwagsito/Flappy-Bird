using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPuntos : MonoBehaviour
{
    public static ControladorPuntos Instancia;

    public delegate void PuntajeDelegado(int puntaje);
    public PuntajeDelegado PuntajeActualizado;
    public PuntajeDelegado MejorpuntajeActuallizado;

    int puntosActuales = 0;
    int mejorPuntuacion;

    private void Awake()
    {
        if (Instancia == null)
        {
            Instancia = this;
        }
        else { Destroy(gameObject); }
    }

    private void Start()
    {
        AdministradorJuego.instancia.JuegoFinalizado += GuardarPuntaje;
        CargarMejorPuntaje();
    }

    public void SumarPuntos()
    {
        puntosActuales++;
        //Debug.Log(puntosActuales);
        PuntajeActualizado?.Invoke(puntosActuales);
    }

    public void GuardarPuntaje()
    {
        if(puntosActuales > mejorPuntuacion)
        {
            PlayerPrefs.SetInt("MejorPuntaje", puntosActuales);
        }

        //Debug.Log(PlayerPrefs.GetInt("MejorPuntaje"));
    }

    public void CargarMejorPuntaje()
    {
        if (PlayerPrefs.HasKey("MejorPuntaje"))
        {
            mejorPuntuacion = PlayerPrefs.GetInt("MejorPuntaje");
        }
        else
        {
            mejorPuntuacion = 0;
        }
        MejorpuntajeActuallizado?.Invoke(mejorPuntuacion);
    }
}
