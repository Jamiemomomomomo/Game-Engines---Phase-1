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
            float randomTime = Random.Range(0, 2f);
            yield return new WaitForSeconds(randomTime);
            row = 0;

            gameBoard.SetValueAt(column, row);

            while(row <= 4)
            {
                yield return new WaitForSeconds(speed);
                gameBoard.SetValueAt(column, row, false);
                row++;

                gameBoard.SetValueAt(column, row);

            }

            gameController.ObjectReachBottom(column);

        }


    }

}
