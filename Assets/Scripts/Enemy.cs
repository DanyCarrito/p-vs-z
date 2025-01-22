using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
