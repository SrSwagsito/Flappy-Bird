using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ParallaxTileset : MonoBehaviour
{
    [SerializeField] private Vector2 movementSpeed;

    private Vector2 offSet;

    private Material material;

    private void Awake()
    {
        material = GetComponent<TilemapRenderer>().material;
    }

    private void Update()
    {
        offSet = movementSpeed * Time.deltaTime;
        material.mainTextureOffset += offSet;
    }
}
