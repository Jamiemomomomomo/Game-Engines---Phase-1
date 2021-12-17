using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pianola : MonoBehaviour
{   
    private string[] mapData;

    private int currentLine = -1;

    [Tooltip("The movement speed (in seconds) of the tools")]
    public float speed = 1f;

    [Tooltip("The list of files that contain the maps")]
    public TextAsset[] mapFiles;

    [Tooltip ("set this to true to run the de")]
    public bool isRunning = false;

    [Tooltip ("The current map index")]
    public int currentMap = 0;

    public GameController gameController;
    public GameBoard gameBoard;

    void Awale()
    {
        print("Test");
        currentMapIndex = 0;
    }
    
    IEnumerator Start()
    {
        while (true)
        {

        

        if (!isRunning)
        {
            yield return null;
        }
        else
        {
        yield return new WaitForSeconds (speed);
        
        if (mapData == null)
        {
            mapData = mapFiles[currentMapIndex].text.Split("\r\n".ToCharArray(), System.StringSplitOptions.RemoveEmptyEntries);
        }


        string line = mapData[currentLine];

        for (int i = 0; i < line.Length; i++)
        {
            int column = (line.Length - 1) - i;
            if (line[i] == '1')
            {
                PianolaObjectFactory.Create(gameObject, column, speed, gameBoard, gameController);
            }
        }

            currentLine--;
            if (currentLine < 0)
            {
                currentLine = mapData.Length - 1;
            }
        }
        }

    }

}
