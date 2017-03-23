using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private BrickWallView brickWallView;
	// Use this for initialization
	void Start () {
        //GameObject wallBrick = GameObject.FindGameObjectWithTag("Brick Wall");
        //Debug.Log(wallBrick);
        brickWallView = GameObject.GetComponent<BrickWallView>();
        Debug.Log("The other object's current is: " + brickWallView.str);
        
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
