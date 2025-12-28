using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MakeTerrain3 : MonoBehaviour
{
    private float frequency = 15f;
    private float amp = 15f;

    void Start()
    {

        Perlin surface = new Perlin();
        Mesh mesh = this.
        GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        for (int v = 0; v < vertices.Length; v++)
        {
            vertices[v].y = surface.Noise(
            vertices[v].x * frequency + 0.1365143f,
            vertices[v].z * frequency + 1.21688f) * amp;
        }
        mesh.vertices = vertices;
        mesh.RecalculateBounds();
        mesh.RecalculateNormals();
        this.gameObject.AddComponent<MeshCollider>();
    }
}
