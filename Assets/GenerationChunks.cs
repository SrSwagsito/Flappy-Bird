using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerationChunks : MonoBehaviour
{
    [SerializeField] bool instanciar;
    [SerializeField] List<Transform> pivotes = new List<Transform>();
    [SerializeField] List<GameObject> instanciarObstaculos = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        if (instanciar == true)
        {
            GenerarObstaculos();
        }

    }

    public void GenerarObstaculos()
    {
        BorrarObstaculos();

        for (int i = 0; i < pivotes.Count; i++)
        {
            int numeroAleatorio = Random.Range(1, 6);

            GameObject obstaculo = (GameObject)Instantiate(Resources.Load("Obstaculo " + numeroAleatorio), pivotes[i]);
            obstaculo.transform.localPosition = Vector3.zero;
            instanciarObstaculos.Add(obstaculo);
        }
    }
    public void BorrarObstaculos()
    {
        for (int i = 0; i < instanciarObstaculos.Count; i++)
        {
            Destroy(instanciarObstaculos[i]);

        }
        instanciarObstaculos.Clear();
    }
}
