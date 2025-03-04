using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ControladorJuegoUI : MonoBehaviour
{
    //public class ControladorInicioUI : MonoBehaviour
    //{
    [SerializeField] Button botonSalto;
    [SerializeField] TextMeshProUGUI textoPuntaje;

    public void OnEnable()
    {
        AdministradorJuego.instancia.JuegoFinalizado += DesactivarBotonSalto;
        ControladorPuntos.Instancia.PuntajeActualizado += ActualizarTextoPuntaje;
    }

    public void ActualizarTextoPuntaje(int nuevoPuntaje)
    {
        //Buscar el game object desde la consola
       // Debug.Log(textoPuntaje.gameObject.name, textoPuntaje.gameObject);
        textoPuntaje.text = nuevoPuntaje.ToString();
    }

    public void DesactivarBotonSalto()
    {
        botonSalto.gameObject.SetActive(false);
    }
}

