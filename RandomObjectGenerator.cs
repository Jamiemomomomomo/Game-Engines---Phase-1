using System.Collections;
using UnityEngine;

public class RandomObjectGenerator : MonoBehaviour
{
    int row;

    public GameController gameController;
    public GameBoard gameBoard;

    float speed = 2f; // The starting speed for each object

    public int column;

    IEnumerator Start()
    {
        while (true)
        {
            float randomTime = Random.Range(0, 5f);
            yield return new WaitForSeconds(randomTime);
            row = Random.Range(0,3);

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
                break;
            }
            else
            {   
                if (row != 5)
                gameBoard.SetValueAt(column, row, false);

                speed -= 0.25f;
                if (speed < 0.25f)
                {
                    speed = 0.25f;
                }
            }
        }
    }
}
