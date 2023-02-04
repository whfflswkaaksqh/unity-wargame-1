using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestVector : MonoBehaviour
{
    public Transform target;
    public float moveSpeed = 5f;
    private Vector3 _movedir;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        _movedir = target.position - transform.position;
        transform.Translate(Time.deltaTime * moveSpeed * _movedir.normalized);
    }
}
