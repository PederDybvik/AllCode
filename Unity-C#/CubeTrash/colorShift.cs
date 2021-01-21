using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class colorShift : MonoBehaviour
{

    public int thisIsLevel;
    public int LevelCleared;


    void Start()
    {

        LevelCleared = PlayerPrefs.GetInt("onLevel", 0);

        if (thisIsLevel <= LevelCleared)
        {
            GetComponent<Image>().color = Color.green;
        }
        if (thisIsLevel == (1 + LevelCleared))
        {
            GetComponent<Image>().color = Color.yellow;
        }
        else if (thisIsLevel > LevelCleared)
        {
            GetComponent<Image>().color = Color.red;
        }





    }

    public void Select()
    {
        if (thisIsLevel < (LevelCleared + 2))
        {
            SceneManager.LoadScene(thisIsLevel.ToString());
        }
        
    }


}
