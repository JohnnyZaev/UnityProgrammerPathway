using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public Vector3 cubePosition = new Vector3(3, 4, 1);
    public Vector3 cubeScale = new Vector3(2, 2, 2);
    public Material material;

    void Start()
    {
        transform.position = cubePosition;
        transform.localScale = cubeScale;

        material = Renderer.material;
        material.color = Random.ColorHSV();
    }
    
    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, 15.0f * Time.deltaTime, 0.0f);
        material.color = Random.ColorHSV();
    }
}
