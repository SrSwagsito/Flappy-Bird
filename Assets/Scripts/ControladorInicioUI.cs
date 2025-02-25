using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ControladorInicioUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textoPuntaje;

    private void OnEnable()
    {
        ControladorPuntos.Instancia.MejorpuntajeActuallizado += ActualizarTextoPuntaje;
    }

    public void ActualizarTextoPuntaje(int nuevoPuntaje)
    {
        textoPuntaje.text = nuevoPuntaje.ToString();
    }
}
