using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public GameController GameController;
    
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (Input.mousePosition.x < Screen.width / 2)
            {
                GameController.MovePlayerLeft();
            }
            else
            {
                GameController.MovePlayerRight();
            }
        }
    }
}
