using System.Collections;
using System.Collections.Generic;
//GlobalAmmo
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour
{
    public int displayAmmo = weaponInfo.currentAmmo;
    public int InternalAmmo;
    public GameObject AmmoDisplay;
    public int internalClip;
    void Update()
    {
        InternalAmmo = weaponInfo.currentAmmo;
        internalClip = weaponInfo.displayClip;
        AmmoDisplay.GetComponent<Text>().text = internalClip + "/" + InternalAmmo;
    }
}
