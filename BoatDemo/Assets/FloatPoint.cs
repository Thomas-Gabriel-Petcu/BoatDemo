using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatPoint : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float waterDensity = 1;
    public float displacedWater = 1;
    public float floaterCount;

    private float _waterHeight;
    private void FixedUpdate()
    {
        _waterHeight = MeshGenerator.Instance.GetHeightAtWorldPosition(transform.position);
        rigidbody.AddForceAtPosition(Physics.gravity/floaterCount, transform.position, ForceMode.Acceleration);
        if (transform.position.y <= _waterHeight)
        {
            rigidbody.AddForceAtPosition(new Vector3(0, displacedWater, 0), transform.position, ForceMode.Acceleration);
        }

    }

}
