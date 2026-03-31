using UnityEngine;
using UnityEngine.SceneManagement;
public class SplashLoader : MonoBehaviour
{
    [SerializeField] float delay = 3f;
    [SerializeField] string nextScene = "Home";
    void Start()
    {
        Invoke("LoadNext", delay);
    }
    void LoadNext()
    {
        SceneManager.LoadScene(nextScene);
    }
}
