using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianolaObject : MonoBehaviour
{
    private int row;
    private bool destroyMe;

    public GameController gameController;
    public GameBoard gameBoard;

    public int column;
    
    public float speed;

    IEnumerator Start()
    {
        while (true)
        {
            do
            {             
                gameBoard.SetValueAt(column, row);
                yield return new WaitForSeconds(speed);
                gameBoard.SetValueAt(column, row, false);
                row++;


            }

            while (row <= 4);

            if (gameController.ObjectReachBottom(column))
            {
                destroyMe = true;
                break;
            }
            else
            {   
                if (row != 5)
                {
                gameBoard.SetValueAt(column, row, false);
                }
            }
        }

        if (destroyMe)
        {
            Destroy(this);
        }
    }
}
