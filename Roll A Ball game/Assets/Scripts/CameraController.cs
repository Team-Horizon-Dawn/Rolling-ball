using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject playingField;

    private Vector3 offset;

    void Start ()
    {
        offset = transform.position - playingField.transform.position;
    }

    void LateUpdate ()
    {
        transform.position = playingField.transform.position + offset;
    }



}