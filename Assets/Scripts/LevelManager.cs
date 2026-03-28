using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
    [SerializeField] TMP_Text lvlText;
    [SerializeField] int nextLvl;
    void Start()
    {
        nextLvl = SceneManager.GetActiveScene().buildIndex + 1;
        lvlText.text = $" Level {SceneManager.GetActiveScene().buildIndex}";
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
        SceneManager.LoadScene(nextLvl);
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Finish"))
        {
            Destroy(other.gameObject);
            Invoke("NextLvl", 4);

            if(nextLvl > PlayerPrefs.GetInt("Level"))
            {
                PlayerPrefs.SetInt("Level", nextLvl);
            }
        }
    }
}
