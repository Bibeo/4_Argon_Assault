using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{

    [SerializeField] float deathDelay = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void RespondToDebugKeys()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            LoadNextLevel();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            LoadPreviousLevel();
        }
    }

    private void LoadPreviousLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex > 0)
        {
            int previousSceneIndex = currentSceneIndex - 1;
            SceneManager.LoadScene(previousSceneIndex);
        }
    }

    private void LoadNextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }
        SceneManager.LoadScene(nextSceneIndex);
    }

    private void LoadFirstLevel()
    {
        SceneManager.LoadScene(0);
    }

}
