using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementOnGrid : MonoBehaviour
{

    public GridManager gridManager;

    private List<List<GameObject>> listGameObjects;
    //private Vector3 offset = new Vector3(0, 1f, 0);
    private int currentColumn = 0;
    private int currentRow = 0;
    private int rows;
    private int cols;

    // Start is called before the first frame update
    void Start()
    {
        listGameObjects = gridManager.GetGameObjects();
        rows = gridManager.rows;
        cols = gridManager.columns;
        transform.position = listGameObjects[currentRow][currentColumn].transform.position + new Vector3(0f, 0.5f, 0f);
    }
}
