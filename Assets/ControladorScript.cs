using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorScript : MonoBehaviour
{
    [SerializeField] List<GenerationChunks> chunks = new List<GenerationChunks>();
    [SerializeField] float velocidad;
    

    [SerializeField] Transform ultimoChunk;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < chunks.Count; i++)
        {
            chunks[i].transform.Translate(Vector3.left * velocidad * Time.deltaTime, Space.World);
             if (chunks[i].transform.position.x <= -7)
            {
                chunks[i].transform.position = ultimoChunk.position + (Vector3.right * 7);
                ultimoChunk = chunks[i].transform;
                chunks[i].GenerarObstaculos();
            }
        }
    }
}
