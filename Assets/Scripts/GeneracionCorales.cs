using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneracionCOrales : MonoBehaviour
{
    [SerializeField] bool instanciar;
    [SerializeField] List<Transform> pivotes = new List<Transform>();
    [SerializeField] List<GameObject> instanciarCorales = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        if (instanciar == true)
        {
            GenerarCorales();
        }

    }

    public void GenerarCorales()
    {
        BorrarCorales();

        for (int i = 0; i < pivotes.Count; i++)
        {
            int numeroAleatorio = Random.Range(1, 8);

            GameObject coral = (GameObject)Instantiate(Resources.Load("Coral " + numeroAleatorio), pivotes[i]);
            coral.transform.localPosition = Vector3.zero;
            instanciarCorales.Add(coral);
        }
    }
    public void BorrarCorales()
    {
        for (int i = 0; i < instanciarCorales.Count; i++)
        {
            Destroy(instanciarCorales[i]);

        }
        instanciarCorales.Clear();
    }
}
