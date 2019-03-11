using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour {

    private Rigidbody2D rb2D;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start() {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        //horizontal < > movement:
        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
        //vertical ^ v movement:
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)) {
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
        }
    }
}
