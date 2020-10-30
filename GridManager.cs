using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    private int rows = 5;
    private int columns = 8;
    private float tileSize = 1;

    // Start is called before the first frame update
    void Start()
    {
        GenerateGrid();
    }

    //nested for loops generate the grid for x and y coordinates in columns and rows putting a grey tile in every location
    private void GenerateGrid()
    {
        GameObject greyTile = (GameObject)Instantiate(Resources.Load("darkgreytile"));
        for (int row = 0; row < rows ; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                GameObject tile = Instantiate(greyTile, transform);

                //sizes the squares to be equal to the prefab greysquare tile
                float posX = col * tileSize;
                float posY = row * -tileSize;

                tile.transform.position = new Vector2(posX, posY);
            }
        }

        //destroys the instantiated prefab since it's no longer needed
        Destroy(greyTile);

        //centers the grid in the center of the camera
        float gridWidth = columns * tileSize;
        float gridHeight = rows * tileSize;
        transform.position = new Vector2(-gridWidth / 2 + tileSize / 2, gridHeight / 2 - tileSize / 2);
    }
}
