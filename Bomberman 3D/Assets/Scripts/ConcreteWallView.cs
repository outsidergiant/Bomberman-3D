﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteWallView : MonoBehaviour {

    public GameObject borderWallTile;
    private int tileNumberX = GlobalParameters.numberTilesX;
    private int tileNumberZ = GlobalParameters.numberTilesZ;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i <= tileNumberZ; i++)
        {
            for (int j = 0; j <= tileNumberX; j++)
            {
                CheckLeft(i, j);
                CheckTop(i, j);
                CheckRight(i, j);
                CheckBottom(i, j);
            }
        }
        AddInnerConcreteWalls();
    }

    void Clone(int x, int z)
    {
        GameObject wallTileClone = (GameObject)Instantiate(borderWallTile, new Vector3(x, 0, z), borderWallTile.transform.rotation);
        wallTileClone.SetActive(true);
    }

    void CheckLeft(int i, int j)
    {
        if (j == 0)
        {
            Clone(j, i);
        }
    }

    void CheckRight(int i, int j)
    {
        if (j == tileNumberX)
        {
            Clone(j, i);
        }
    }

    void CheckTop(int i, int j)
    {
        if (i == 0)
        {
            Clone(j, i);
        }
    }

    void CheckBottom(int i, int j)
    {
        if (i == tileNumberZ)
        {
            Clone(j, i);
        }
    }
    

    void AddInnerConcreteWalls()
    {
        for (int i = 2; i < tileNumberZ; i += 2)
        {
            for (int j = 2; j < tileNumberX; j += 2)
            {
                GameObject wallTileClone = (GameObject)Instantiate(borderWallTile, new Vector3(j, 0, i), borderWallTile.transform.rotation);
                wallTileClone.SetActive(true);
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