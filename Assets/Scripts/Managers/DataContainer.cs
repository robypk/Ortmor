using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class DataContainer : MonoBehaviour
{

    public static DataContainer Instance;
    public List<Character> SelectedCharacters = new List<Character>();
    public Texture2D capturePhoto;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SceneLoad(int SceneIndex)
    {
        SceneManager.LoadScene( SceneIndex);
    }



}
