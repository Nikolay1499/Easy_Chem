using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {
	void Update () {
        transform.Rotate(new Vector3(0, 25, 0) * Time.deltaTime);
    }
}
