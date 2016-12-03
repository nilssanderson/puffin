using UnityEngine;

public class n_Hole : MonoBehaviour {

	/* Variables ================================================================= */

    private Transform n_HolderTransform;
    private Vector3 n_StartingPosition;


	/* Functions ================================================================= */

    void Start() {
        n_HolderTransform = GameObject.FindGameObjectWithTag("MainCamera").transform;
        n_StartingPosition = n_HolderTransform.position;
    }

    public void Restart() {
        n_HolderTransform.position = n_StartingPosition;
    }

    void OnTriggerEnter(Collider _collider) {
        if (_collider.gameObject.tag == "Projectile") {
            Debug.Log("Frisbee has entered!");
            _collider.gameObject.GetComponent<n_Frisbee>().inTheHole = true;
        }
    }

}