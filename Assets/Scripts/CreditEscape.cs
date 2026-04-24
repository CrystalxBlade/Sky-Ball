using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditEscape : MonoBehaviour
{
    bool cursorRequest;
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
        cursorRequest = false;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            cursorRequest = !cursorRequest;
            
            if(cursorRequest)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
    }
}
