using UnityEngine;

public class n_Projectile : MonoBehaviour {

	/* Variables ================================================================= */

    public int n_ProjectileForce;

    [HideInInspector] public bool n_IsMoving = false;


	/* Functions ================================================================= */

    public void AddForce() {
        GetComponent<Rigidbody>().AddForce(transform.forward * n_ProjectileForce);
        n_IsMoving = true;
    }

}