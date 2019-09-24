using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class BoxController : MonoBehaviour {

    [Range(1, 10)] public float speed = 2;
    public bool shouldFlash = true;

    public GameObject ground;


    MeshRenderer meshRenderer;

    void Start() {
        //MeshRenderer meshRenderer = (MeshRenderer)GetComponent("MeshRenderer");
        //MeshRenderer meshRenderer = (MeshRenderer)GetComponent(typeof(MeshRenderer));

        meshRenderer = GetComponent<MeshRenderer>();

    }

    void Update() {
        
        if (meshRenderer != null && shouldFlash) {
            float r = Random.Range(0, 1f);
            float g = Random.Range(0, 1f);
            float b = Random.Range(0, 1f);

            meshRenderer.material.color = new Color(r, g, b);
        }

        
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.position += new Vector3(h, v, 0) * Time.deltaTime * speed;
    }

    void OnDestroy() {

    }
}
