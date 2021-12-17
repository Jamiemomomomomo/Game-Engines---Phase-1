using UnityEngine;

public class GameController : MonoBehaviour
{
    int HandymanColumn = 0;

    int hammerRow = 0;

    public GameBoard gameBoard;

    public void ObjectReachBottom(int column)
    {
    }

    public void MovePlayerLeft()
    {
        gameBoard.SetValueAt(HandymanColumn,5 ,false);

        HandymanColumn--;
        if (HandymanColumn < 0)
        {
            HandymanColumn = 0;
        }

        gameBoard.SetValueAt(HandymanColumn,5 ,true);

    }

    public void MovePlayerRight()
    {
        gameBoard.SetValueAt(HandymanColumn,5 ,false);

        HandymanColumn++;
        if (HandymanColumn <4)
        {
            HandymanColumn = 4;
        }
        
        gameBoard.SetValueAt(HandymanColumn,5 ,true);
    }

    void Start()
    {
        gameBoard.SetValueAt(HandymanColumn, 5, true);
    }
    
    
}
