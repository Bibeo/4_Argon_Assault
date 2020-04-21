using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject deathFX;
    [SerializeField] Transform parent;

    ScoreBoard scoreBoard;

    //[SerializeField] int scoreHit = 12; In the tutorial
    //My own bonus points :
    [SerializeField] int scoreHitBase = 12;
    int scorePerHit;
    [SerializeField] int bonusTimeScore = 42;

    [SerializeField] int Hits = 3;

    // Start is called before the first frame update
    void Start()
    {
        AddNonTriggerBoxCollider();
        scoreBoard = FindObjectOfType<ScoreBoard>();
    }

    private void AddNonTriggerBoxCollider()
    {
        Collider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;
    }

    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
        if (Hits <= 0)
        {
            killEnemy();
        }
    }

    private void ProcessHit()
    {
        scorePerHit = (bonusTimeScore - Mathf.RoundToInt(Time.time)) * scoreHitBase;
        scoreBoard.ScoreHit(scorePerHit);
        //Shorter way to say : maxHits = maxHits - 1;
        Hits--;
        // todo consider hit FX
    }

    private void killEnemy()
    {
        //We call first, the gameobject to instantiate, then we set its position, finally its rotation (if needed), here we're just reading the rotation not acting
        GameObject fx = Instantiate(deathFX, transform.position, Quaternion.identity);
        fx.transform.parent = parent;
        Destroy(gameObject);
    }
}
