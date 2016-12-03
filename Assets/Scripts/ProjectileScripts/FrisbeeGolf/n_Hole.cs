using UnityEngine;

public class n_Hole : MonoBehaviour {

	/* Variables ================================================================= */

    private Transform n_HolderTransform;


	/* Functions ================================================================= */

    void OnTriggerEnter(Collider _collider) {
        if (_collider.gameObject.tag == "Projectile") {
            Debug.Log("Frisbee has entered!");
            _collider.gameObject.GetComponent<n_Frisbee>().inTheHole = true;
        }
    }

}