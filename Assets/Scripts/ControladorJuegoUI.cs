using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ControladorJuegoUI : MonoBehaviour
{
    //public class ControladorInicioUI : MonoBehaviour
    //{
    [SerializeField] TextMeshProUGUI textoPuntaje;

    public void OnEnable()
    {
        ControladorPuntos.Instancia.PuntajeActualizado += ActualizarTextoPuntaje;
    }

    public void ActualizarTextoPuntaje(int nuevoPuntaje)
    {
        //Buscar el game object desde la consola
       // Debug.Log(textoPuntaje.gameObject.name, textoPuntaje.gameObject);
        textoPuntaje.text = nuevoPuntaje.ToString();
    }
}

