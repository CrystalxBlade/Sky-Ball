using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditEscape : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(1);
        }
    }
}
