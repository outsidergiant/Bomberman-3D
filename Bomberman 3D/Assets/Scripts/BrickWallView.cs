using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickWallView : MonoBehaviour {

    public GameObject brickWall;
    public int numberOfWalls;
    public bool bob;

    private bool[,] wallMap;
	// Use this for initialization
	void Start () {
        wallMap = new bool[GlobalParameters.numberTilesX, GlobalParameters.numberTilesZ];
        PlaceWalls();
	}

    void PlaceWalls()
    {
         
        for (int i = 0; i < numberOfWalls; i++)
        {
            int x = -1;
            int z = -1;
            do
            {
                x = (int)Random.Range(1, GlobalParameters.numberTilesX - 1);
                z = (int)Random.Range(1, GlobalParameters.numberTilesZ - 1);
            } while (x % 2 == 0 && z % 2 == 0 && !wallMap[x, z]);
            wallMap[x, z] = true;
            Clone(x, z);
        }
    }

    void Clone(int x, int z)
    {
        GameObject brickWallClone = (GameObject)Instantiate(brickWall, new Vector3(x, 0, z), brickWall.transform.rotation);
        brickWallClone.SetActive(true);
    }
}
