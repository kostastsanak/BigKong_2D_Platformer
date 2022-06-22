using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    [SerializeField] int score;

    void OnTriggerEnter2D(Collider2D other) {
        Destroy(gameObject);
        score++;
        Debug.Log("Score :"+score);
    }

}
