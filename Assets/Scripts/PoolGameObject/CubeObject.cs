using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class CubeObject : MonoBehaviour
{
    Vector3 _velocity;

    [Inject]
    public void Construct()
    {
        Reset(Vector3.zero);
    }

    public void Update()
    {
        transform.position += _velocity * Time.deltaTime;
    }

    void Reset(Vector3 velocity)
    {
        transform.position = new Vector3(Random.Range(1f,10f),Random.Range(1f,10f),Random.Range(1f,10f));
        _velocity = velocity;
    }

    public class Pool : MonoMemoryPool<Vector3, CubeObject>
    {
        protected override void Reinitialize(Vector3 velocity, CubeObject cubeObject)
        {
            cubeObject.Reset(velocity);
        }
    }
}
