using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //ok as long as this is the only script that load scenes

public class CollisionHandler : MonoBehaviour
{
    [Tooltip("In seconds")][SerializeField] float levelLoadDelay = 2f;
    [Tooltip("FX prefab on player")][SerializeField] GameObject deathFX;

    void OnTriggerEnter(Collider other)
    {
        StartDeathSequence();
    }
    
    private void StartDeathSequence()
    {
        SendMessage("OnPlayerDeath");
        deathFX.SetActive(true);
        Invoke("RealoadScene", levelLoadDelay);
    }

    private void RealoadScene() //String referenced (NB: A reminder that it's a a string, so we need it to be changed, we need to change it manually for each time it's called
    {
        SceneManager.LoadScene(1);
    }
}
