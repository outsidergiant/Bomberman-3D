using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderWallView : MonoBehaviour {

    public GameObject borderWallTile;
    public int tileNumberX;
    public int tileNumberZ;

    // Use this for initialization
    void Start()
    {
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

        AddInnerConcreteWalls();
    }

    void AddInnerConcreteWalls()
    {
        for (int i = 2; i < tileNumberZ; i += 2)
        {
            for (int j = 2; j < tileNumberX; j += 2)
            {
                GameObject wallTileClone = (GameObject)Instantiate(borderWallTile, new Vector3(j, 0, i), borderWallTile.transform.rotation);
                borderWallTile.SetActive(true);
            }
        }
    }
    /*void AddInnerWallTiles()
    {
        int numberOfWallTiles = (int)(tileNumberX * tileNumberZ * 0.2); //because I want so.
        bool[,] wallMap = new bool[tileNumberX, tileNumberZ];
        for (int i = 0; i < numberOfWallTiles; i++)
        {
            int x = -1;
            int z = -1;
            do
            {
                x = (int)Random.RandomRange(2, tileNumberX - 2);
                z = (int)Random.RandomRange(2, tileNumberZ - 2);
            } while (!(wallMap[x, z] && wallMap[x - 1, z] && wallMap[x + 1, z] && wallMap[x, z + 1] && wallMap[x, z - 1] && wallMap[x + 1, z + 1]
                && wallMap[x + 1, z - 1] && wallMap[x - 1, z + 1] && wallMap[x - 1, z + 1]));

            //if ( )

            {

            }
        }

    } */
}
