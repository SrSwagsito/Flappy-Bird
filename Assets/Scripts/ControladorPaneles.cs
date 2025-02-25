using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPaneles : MonoBehaviour
{
    [SerializeField] GameObject panelInicio, panelPausa, panelFDJ, panelJuego;

    public void OnEnable()
    {
        AdministradorJuego.instancia.JuegoIniciado += MostrarPanelJuego;
        AdministradorJuego.instancia.JuegoPausado += MostrarPanelPausa;
        AdministradorJuego.instancia.JuegoReanudado += MostrarPanelJuego;
        AdministradorJuego.instancia.JuegoFinalizado += MostrarPanelFDJ;
    }

    //public void MostrarPanelInicio() 
    //{
    //    panelInicio.SetActive(true);
    //    panelPausa.SetActive(false);
    //    panelFDJ.SetActive(false);
    //    panelJuego.SetActive(false);
    //}
    public void MostrarPanelPausa() 
    {
        panelInicio.SetActive(false);
        panelPausa.SetActive(true);
        panelFDJ.SetActive(false);
        panelJuego.SetActive(false);
    }
    public void MostrarPanelFDJ() 
    {
        panelInicio.SetActive(false);
        panelPausa.SetActive(false);
        panelFDJ.SetActive(true);
        panelJuego.SetActive(false);
    }
    public void MostrarPanelJuego() 
    {
        panelInicio.SetActive(false);
        panelPausa.SetActive(false);
        panelFDJ.SetActive(false);
        panelJuego.SetActive(true);
    }
}
