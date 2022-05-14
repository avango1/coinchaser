using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartScript : MonoBehaviour
{
    [SerializeField] Text recordText;
    private void Start()
    {
        int LastRunScore = PlayerPrefs.GetInt("LastRunScore");
        int recordScore = PlayerPrefs.GetInt("recordScore");

        if (LastRunScore > recordScore) 
        {
            recordScore = LastRunScore;
            PlayerPrefs.SetInt("recordScore", recordScore);
            recordText.text = recordScore.ToString();
        }
        else
        {
            recordText.text = recordScore.ToString();
        }
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }

    public void ToMenu()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
}
