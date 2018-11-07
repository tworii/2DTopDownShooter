using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour {

    // Use this for initialization
    void OnTriggerEnter2D(Collider2D col)
    {
        weaponInfo.currentAmmo += 10;
        this.gameObject.SetActive(false);
    }
}
