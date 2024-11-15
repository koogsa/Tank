using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShoot : MonoBehaviour
{
    public Rigidbody prefabShell;
    public Transform fireTransform;
    public int playerNum = 1;
    string fireName;

    void Start()
    {
        fireName = "Fire" + playerNum;
    }

    void Update()
    {
        if (Input.GetButtonDown(fireName))
        {
            Fire();
        }
    }

    void Fire()
    {
        Rigidbody shellInstance = Instantiate(prefabShell, fireTransform.position, fireTransform.rotation) as Rigidbody;

        shellInstance.velocity = 20.0f * fireTransform.forward;
    }
}
