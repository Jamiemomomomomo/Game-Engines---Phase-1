using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display: MonoBehaviour
{
    GameObject[,] grid = new GameObject[5,6];

    [Tooltip("The gameboard that indicates what pieces are to be displayed")]
    public GameBoard gameBoard;

    [Tooltip("The parent in object that holds the obstacle columns")]
    public GameObject[] columns;

    [Tooltip("The handyman game objects")]
    public GameObject[] Handyman;

    void Awake()
    {
        SetupGrid();
        StartCoroutine(UpdateDisplay());
    }
    
    void SetupGrid()
    {
        for (int x = 0; x < columns.Length; x++)
        {
            int y = 0;

            foreach(Transform t in columns[x].transform)
            {
                grid[x, y] = t.gameObject;
                y++;
            }
        }

        for (int x = 0; x < Handyman.Length; x++)
        {
            foreach(var go in Handyman)
            {
                grid[x, 5] = Handyman[x];
            }
        }
    }

    IEnumerator UpdateDisplay()
    {
        while (true)
        {
            for(int y = 0; y < 6; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    grid[x,y].SetActive(gameBoard.GetValueAt(x, y));
                }
            }

            yield return null;
        }
    }
}
