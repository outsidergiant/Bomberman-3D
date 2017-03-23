using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private BrickWallView brickWallView;
	// Use this for initialization
	void Start () {
        brickWallView = (BrickWallView)FindObjectOfType(typeof(BrickWallView));
        int x = -1;
        int z = -1;
        do
        {
            x = (int)Random.Range(1, GlobalParameters.numberTilesX - 1);
            z = (int)Random.Range(1, GlobalParameters.numberTilesZ - 1);
        } while (x % 2 == 0 || z % 2 == 0 || brickWallView.wallMap[x, z]);
        transform.position = new Vector3(x, GlobalParameters.Y, z);
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
