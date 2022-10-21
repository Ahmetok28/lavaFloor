using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField]
    GameObject shpere;
    Vector3 distance;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        distance = transform.position - shpere.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = shpere.transform.position + distance;
        float hInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * hInput * rotationSpeed * Time.deltaTime);
    }
}
