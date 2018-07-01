using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapData : MonoBehaviour {

    public int width = 10;
    public int height = 5;

    void Start () {
        //int[,] mapInstance = MakeMap();
	}

    public int[,] MakeMap() {
        //temp array
        int[,] map = new int[width, height];
        for (int y = 0; y < height; y++) {
            for (int x = 0; x < width; x++) {
                //default to open 0
                map[x, y] = 0;
            }
        }
        //add blocked walls 1 and leave open spaces 0 connected to draw path from 1 part of the maze to another
        map[1, 0] = 1;
        map[1, 1] = 1;
        map[1, 2] = 1;

        return map;
    }
}
