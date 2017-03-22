using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileView : MonoBehaviour {

    public GameObject tile;
    public int width;
    public int height;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
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
