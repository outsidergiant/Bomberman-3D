using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderWallView : MonoBehaviour {

    public GameObject borderWallTile;
    //public int width;
    //public int height;

    private TileView tileView;
    // Use this for initialization
    void Start()
    {
        tileView = new TileView();
        int tileNumberX = 10;//= tileView.numberOfTilesX;
        int tileNumberZ = 10;//= tileView.numberOfTilesZ;

        for (int i = 0; i <= tileNumberX; i++)
        {
            GameObject wallTileClone = (GameObject)Instantiate(borderWallTile, new Vector3(i, 0, 0), borderWallTile.transform.rotation);
            borderWallTile.SetActive(true);
        }
        for (int i = 0; i <= tileNumberZ; i++)
        {
            GameObject wallTileClone = (GameObject)Instantiate(borderWallTile, new Vector3(tileNumberX, 0, i), borderWallTile.transform.rotation);
            borderWallTile.SetActive(true);
        }
        for (int i = 0; i <= tileNumberX; i++)
        {
            GameObject wallTileClone = (GameObject)Instantiate(borderWallTile, new Vector3(i, 0, tileNumberZ), borderWallTile.transform.rotation);
            borderWallTile.SetActive(true);
        }
        for (int i = 0; i <= tileNumberZ; i++)
        {
            GameObject wallTileClone = (GameObject)Instantiate(borderWallTile, new Vector3(0, 0, i), borderWallTile.transform.rotation);
            borderWallTile.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
