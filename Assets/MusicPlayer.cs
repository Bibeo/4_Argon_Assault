using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{
    //TO not destroy the gameobject and so the music on it when we switch level
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
        Invoke("LoadFirstLevel", 3f);
    }

    void LoadFirstLevel()
    {
        SceneManager.LoadScene(1);
    }
}
