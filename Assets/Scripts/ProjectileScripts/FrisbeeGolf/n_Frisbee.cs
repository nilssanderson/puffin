using UnityEngine;
using UnityEngine.SceneManagement;

public class n_Frisbee : MonoBehaviour {

	/* Variables ================================================================= */

    public float n_StoppingDistance = 0.5f;
    public float n_HolderTransformYOffset;

    [HideInInspector] public bool inTheHole = false;

    private Transform n_HolderTransform;
    private GameObject n_Hole;


	/* Functions ================================================================= */

    void Start() {
        n_HolderTransform = GameObject.FindGameObjectWithTag("MainCamera").transform;
        n_Hole = GameObject.FindGameObjectWithTag("Hole");
    }

    void Update() {

        // If object is moving
        if (GetComponent<n_Projectile>().n_IsMoving) {
            float _speed = GetComponent<Rigidbody>().velocity.magnitude;

            if (_speed < n_StoppingDistance) {
                GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                GetComponent<n_Projectile>().n_IsMoving = false;

                if (inTheHole) {
                    Debug.Log("Win!");
                    n_Hole.GetComponent<n_Hole>().Restart();
                } else {
                    // Move camera to the new position
                    // plus the offset value
                    // and destroy projectile
                    n_HolderTransform.position = new Vector3(
                        transform.position.x,
                        transform.position.y + n_HolderTransformYOffset,
                        transform.position.z
                    );
                    Destroy(gameObject);
                }
            }
        }

        // Destroy if below sea level
        if (transform.position.y <= 0) {
            Destroy(gameObject);
        }
    }

}