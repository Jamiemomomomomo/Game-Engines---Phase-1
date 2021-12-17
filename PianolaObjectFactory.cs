using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PianolaObjectFactory
{
    public static PianoObject Create(GameObject go, int column, float speed, GameBoard gameBoard,
    GameController gameController)
    {
        var obj = go.AddComponent<PianolaObjectFactory>();
        obj.column = column;
        obj.speed = speed;
        obj.gameBoard = gameBoard;
        obj.gameController = gameController;
        return obj;
    }
}
