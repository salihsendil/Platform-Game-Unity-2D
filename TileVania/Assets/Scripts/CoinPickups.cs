using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickups : MonoBehaviour
{
    [SerializeField] AudioClip coinSound;
    [SerializeField]int coinPoint = 100;
    bool wasCollected = false;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && !wasCollected)
        {
            wasCollected = true;
            FindObjectOfType<GameSession>().addToScore(coinPoint);
            AudioSource.PlayClipAtPoint(coinSound, Camera.main.transform.position, 0.5f);
            gameObject.SetActive(false);
            Destroy(gameObject);

        }
    }

}
