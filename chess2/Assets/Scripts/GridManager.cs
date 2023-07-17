using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int _width, _height;

    [SerializeField] private Tile _tilePrefab;

	[SerializeField] private Transform _camera;

	void Start ()
	{
		GeneratedGrid();
	}
    
	// Function to generate the grid based on width and height
    void GeneratedGrid() 
    {
		// Loop over the width of the board
    	for (int x = 0; x < _width; x++)
    	{
			// Loop over the height of the board
    		for (int y = 0; y < _height; y++)
    		{
				// Spawn a tile at the current x,y and name it 'Tile (x) (y)'
    			var spawnedTile = Instantiate(_tilePrefab, new Vector3(x, y), Quaternion.identity);
				spawnedTile.name = $"Tile {x} {y}";

				// Determine tile color based on x and y positions
				var isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);

				// Apply color
				spawnedTile.Init(isOffset);
    		}
    	}

		// Center the main camera on grid (the -0.5f are to account for half a tiles width or height)
		_camera.transform.position = new Vector3((float)_width / 2 -0.5f, (float)_height / 2 -0.5f, -10);
    }   
}
