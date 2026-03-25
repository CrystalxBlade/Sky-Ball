using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
    [SerializeField] TMP_Text lvlText;
    [SerializeField] int lvl;
    void Start()
    {
        lvl = SceneManager.GetActiveScene().buildIndex;
        lvlText.text = $" Level {lvl}";
    }
    void Update()
    {
        if(transform.position.y < -10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    void NextLvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Finish"))
        {
            Destroy(other.gameObject);
        }
    }
}
