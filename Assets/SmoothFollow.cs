using UnityEngine;
using System.Collections;

public class SmoothFollow : MonoBehaviour {

    public Transform target;
    public float dampTime = 0.3f;
    private Transform thisTransform;
    private Vector3 velocity = new Vector3(1, 1, 1);
    private Transform mycamera;

    void Start()
    {
        mycamera = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }

    void Update()
    {
        //float x = Mathf.SmoothDamp(mycamera.position.x, target.position.x, ref velocity.x, dampTime);
        //float z = Mathf.SmoothDamp(mycamera.position.z, target.position.z, ref velocity.z, dampTime);

        mycamera.position = new Vector3(target.position.x, 0, target.position.z);
    }
}
