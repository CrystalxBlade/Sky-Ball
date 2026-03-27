using UnityEngine;
using UnityEngine.SceneManagement;
public class Level_Select : MonoBehaviour
{
    [SerializeField] int lvlNo;

    public void LoadLvl()
    {
        SceneManager.LoadScene(lvlNo);
    }
}
