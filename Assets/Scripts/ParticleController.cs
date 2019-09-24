using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace NicklesMcPickles
{

    public class ParticleController : MonoBehaviour
    {

        Vector3 velocity = new Vector3();

        void Start() {
            velocity = Random.onUnitSphere * 5;
        }


        void Update() {
            // euler physics:
            velocity += new Vector3(0, -10, 0) * Time.deltaTime;
            transform.position += velocity * Time.deltaTime;

            if (transform.position.y < -10) {
                Destroy(gameObject);
            }

        }

        void OnMouseDown() {
            Destroy(gameObject);
            print("CLICKED ON A PARTICLE");
        }

    }
}
