using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileView : MonoBehaviour {

    public GameObject tile;
    public int numberOfTilesX;
    public int numberOfTilesZ;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < numberOfTilesZ; i++)
        {
            for (int j = 0; j < numberOfTilesX; j++)
            {
                GameObject tileClone = (GameObject)Instantiate(tile, new Vector3(j, 0, i), tile.transform.rotation);
                tileClone.SetActive(true);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
