using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapGenerator : MonoBehaviour
{

    public Tilemap[] tilemaps;
    public Tile boxfillTile;

    delegate void MyDelegate();
    MyDelegate myDelegate;


    // Use this for initialization
    void Start()
    {
        //tilemaps[0].BoxFill(new Vector3Int(0, 0, 0), boxfillTile, -5, -5, 10, 10);

    }

    // Update is called once per frame
    void Update()
    {
        if (myDelegate != null)
            myDelegate();
        if (Input.GetKeyDown(KeyCode.B))
        {
            myDelegate -= placeTiles;
            myDelegate += placeTiles;
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            myDelegate -= placeTiles;

        }

    }

    void placeTiles()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 worldPoint = ray.GetPoint(-ray.origin.z / ray.direction.z);

        if (Input.GetMouseButtonDown(0))
        {
            tilemaps[1].SetTile(tilemaps[1].WorldToCell(worldPoint), boxfillTile);
        }


    }

}
