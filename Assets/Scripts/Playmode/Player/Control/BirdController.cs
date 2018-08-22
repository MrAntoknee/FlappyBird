using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour {

    [SerializeField] private KeyCode flapKey = KeyCode.Space;

    private BirdPhysics birdPhysics;

    private void Awake()
    {
        birdPhysics = transform.root.GetComponentInChildren<BirdPhysics>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(flapKey))
            birdPhysics.Flap();
    }
}
