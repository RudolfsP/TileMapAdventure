﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour {

    [SerializeField] AudioClip coinPickupSFX;
    [SerializeField] int pointsForCoin = 100;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D otherCollider) {
        FindObjectOfType<GameSession>().AddToScore(pointsForCoin);
        AudioSource.PlayClipAtPoint(coinPickupSFX, Camera.main.transform.position);
        Destroy(gameObject);
    }
}
