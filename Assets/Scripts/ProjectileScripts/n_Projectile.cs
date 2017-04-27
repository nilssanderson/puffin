using UnityEngine;

public class n_Projectile : MonoBehaviour {

	/* Variables ================================================================= */

    public int n_ProjectileForce;

    [HideInInspector] public bool n_IsMoving = false;

    private Transform n_HolderTransform;


	/* Functions ================================================================= */

    void Start() {
        n_HolderTransform = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }

    public void AddForce() {
        n_HolderTransform.GetComponent<n_Holder>().n_CanShoot = false;
        GetComponent<Rigidbody>().AddForce(transform.forward * n_ProjectileForce);
        n_IsMoving = true;
    }

}