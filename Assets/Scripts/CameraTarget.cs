using UnityEngine;
using System.Collections;

public class CameraTarget : MonoBehaviour {

    public Transform target;
    public float distance = 10.0f;
    public float distancetoTarget = 10.0f;

	// Use this for initialization
	void Start () {

        transform.position = target.position + Vector3.back * distance;

    }

    // Update is called once per frame
    void Update () {
        Vector3 Diff = transform.position - target.position;
        if (Diff.magnitude > distancetoTarget)
        {
            float mult = distancetoTarget / Diff.magnitude;
            transform.position -= Diff;
            transform.position += Diff * mult;
        }
    }
}
