using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    void Start() {
    }

    void OnTriggerEnter2D(Collider2D collision) {
        print("triggered on paddle");
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        print("collision on paddle");
    }
}
