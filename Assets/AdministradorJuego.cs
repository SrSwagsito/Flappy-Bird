using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdministradorJuego : MonoBehaviour
{

    public static AdministradorJuego instancia;
    
    public delegate void EstadosJuegoDelegado();
    public EstadosJuegoDelegado JuegoIniciado;
    public EstadosJuegoDelegado JuegoPausado;
    public EstadosJuegoDelegado JuegoReanudado;
    public EstadosJuegoDelegado JuegoFinalizado;
    private void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
        }
        else 
        {
            Destroy(gameObject);
        } 
        Time.timeScale = 0;
    }

    public void IniciarJuego() 
    {
        JuegoIniciado?.Invoke();
            Time.timeScale = 1;
    }
    public void PausarJuego() 
    {
        JuegoPausado?.Invoke();
            Time.timeScale = 0;
    }
    public void ReanudarJuego() 
    { 
        JuegoReanudado?.Invoke();
        Time.timeScale = 1;
    }
    public void FinalizarJuego() 
    { 
        JuegoFinalizado?.Invoke();
        Time.timeScale = 0;
    }
    public void CerrarJuego() 
    {
        Application.Quit();
    }
    public void ReiniciarJuego() 
    {
        SceneManager.LoadScene("SampleScene");
    }

    

}
