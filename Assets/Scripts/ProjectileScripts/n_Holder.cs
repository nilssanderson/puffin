﻿using UnityEngine;
using System.Collections;

public class n_Holder : MonoBehaviour {

	/* Variables ================================================================= */

    public bool fireBow;
    public Transform theBow;
    public GameObject anArrow;
    public GameObject instArrow;
    public float arrows;

    public Transform n_ProjectilePrefab;

    public bool n_CanShoot = true;
    private Transform _projectile;


	/* Functions ================================================================= */

    // void Update() {

    //     if (fireBow == true) {
    //         GameObject.Find ("Main Arrow").GetComponent<Arrow> ().fireArrow = true;
    //         holder.animation = false;
    //     }

    //     if (Input.GetKeyDown ("t")) {
    //         if (arrows >= 1) {
    //             fireBow = true;
    //             arrows = arrows - 1;
    //             ShootArrow ();
    //             GameObject.Find ("Bow Arrow").GetComponent<BowArrow> ().playAnim = true;
    //         }
    //     }
    // }

    void Update() {
        // Put this in your update function
        if (Input.GetButtonDown("Fire1")) {

            if (n_CanShoot) {
                // Instantiate the projectile at the position and rotation of this transform
                _projectile = (Transform)Instantiate(n_ProjectilePrefab, transform.position, transform.rotation);
            } else {
                // Add force to the cloned object in the object's forward direction
                _projectile.GetComponent<n_Projectile>().AddForce();
            }
        }
    }

}