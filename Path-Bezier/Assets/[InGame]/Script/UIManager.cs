using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public int level { get { return PlayerPrefs.GetInt("levelData", 0); } set { PlayerPrefs.SetInt("levelData", value); } }
    public int maxLevel;

    private void Start()
    {
        maxLevel = SceneManager.sceneCountInBuildSettings;
    }
    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }

    public void NextLevelButton()
    {
        level++;
        if(level > maxLevel-1)
            level = 0;
        SceneManager.LoadScene(level);
    }
}
