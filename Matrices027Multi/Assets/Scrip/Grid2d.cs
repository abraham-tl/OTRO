using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid2d : MonoBehaviour {
    public int width;
    public int height;
    public GameObject puzzlePiece;
    private GameObject[,] grid;
	// Use this for initialization
	void Start () {

        grid = new GameObject[width, height];
        for (int x =0; x<width;x++ )
        {
            for (int y=0;y<height; y++)
            {
                GameObject go = GameObject.Instantiate(puzzlePiece) as GameObject;
                Vector3 position = new Vector3(x, y, 0);
                go.transform.position = position;
                grid[x, y] = go;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 mposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        print("Pos X "+Input.mousePosition.x + "Pos Y "+ Input.mousePosition.y);
        UpdatePickedPiece(mposition);
    }
    void UpdatePickedPiece(Vector3 mposition_)
    {

        Debug.DrawLine(Vector3.zero, mposition_);
        int x = (int)(mposition_.x + 0.5f);
        int y = (int)(mposition_.y + 0.5f);

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                GameObject go = grid[i, j];
                go.GetComponent<Renderer>().material.SetColor("_Color", Color.white);
            }
        }
        if (x >= 0 && y >= 0 && x < width && y < height)
        {
            GameObject go = grid[x, y];
            go.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        }
    }
}
    