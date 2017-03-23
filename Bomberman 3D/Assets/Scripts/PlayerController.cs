using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private BrickWallView brickWallView;
    public float speed;
    public Rigidbody rigidBody;
	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
        brickWallView = (BrickWallView)FindObjectOfType(typeof(BrickWallView));
        int x = -1;
        int z = -1;
        do
        {
            x = (int)Random.Range(1, GlobalParameters.numberTilesX - 1);
            z = (int)Random.Range(1, GlobalParameters.numberTilesZ - 1);
        } while (x % 2 == 0 || z % 2 == 0 || brickWallView.wallMap[x, z]);
        transform.position = new Vector3(x, GlobalParameters.Y * 2, z);
	}
	
	void FixedUpdate () {
        rigidBody.velocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * 10;
	}
}
