using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelSelectScript : MonoBehaviour
{

    public void resetLevel()
    {
        PlayerPrefs.SetInt("onLevel", 0);
    }




    public void Select(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }











}
