using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumadorPuntos : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ControladorPuntos.Instancia.SumarPuntos();
        }
    }
}
