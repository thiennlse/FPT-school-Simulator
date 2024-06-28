using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    /*public float Speed = 2.0f;*/
    [SerializeField]
    private Transform target;
    // Update is called once per frame
    void Update()
    {

        /*Vector3 newPos = new Vector3(
             Mathf.Clamp(target.position.x,-6.5f,5.5f),
            Mathf.Clamp(target.position.y, 3.1f,-4f),
            transform.position.z);
        transform.position = Vector3.Slerp(transform.position, newPos, Speed * Time.deltaTime);*/


        transform.position = new Vector3(
            Mathf.Clamp(target.position.x, -81f, 16.9f),
            Mathf.Clamp(target.position.y, -8f, 55.3f),
            transform.position.z);
    }

}
