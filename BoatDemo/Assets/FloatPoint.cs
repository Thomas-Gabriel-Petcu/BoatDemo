using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FloatPoint : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float waterDensity = 1;
    public float displacedWater = 1;

    private float _waterHeight;
    private void FixedUpdate()
    {
        //int index = Mathf.RoundToInt(transform.position.x) * Mathf.RoundToInt(transform.position.z);

        _waterHeight = MeshGenerator.Instance.GetHeightAtWorldPosition(transform.position);
        //rigidbody.AddForceAtPosition(Physics.gravity, transform.position, ForceMode.Acceleration);
        transform.position = new Vector3(transform.position.x,_waterHeight,transform.position.z);

        //if (transform.position.y <= _waterHeight)
        //{
        //    rigidbody.AddForceAtPosition(new Vector3(0,displacedWater,0), transform.position,ForceMode.Force);
        //}
        
    }
   
}
