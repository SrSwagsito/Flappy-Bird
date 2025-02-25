using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    Rigidbody2D rigidbody2;
    [SerializeField] float fuerzasalto;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
    }

    public void Salto()
    {
        rigidbody2.velocity = new Vector2(0, fuerzasalto);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Respawn"))
        {
            AdministradorJuego.instancia.FinalizarJuego();
        }
    }
}
