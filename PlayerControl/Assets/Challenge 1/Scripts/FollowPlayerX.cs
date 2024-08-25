using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(0, 5, -15);

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - plane.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Position behind plane based on current position
        Vector3 currentPosition = plane.transform.position + plane.transform.TransformDirection(offset);
        transform.position = currentPosition;
        transform.LookAt(plane.transform.position);
    }
}
