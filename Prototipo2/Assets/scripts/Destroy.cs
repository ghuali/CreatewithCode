using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float topBound = 30;
    private float lowerBound = -10;
    void Update() {
if (transform.position.z > topBound)
    {
    Destroy(gameObject);
    } else if (transform.position.z < lowerBound)
    {
    Debug.Log("Game Over!");
    Destroy(gameObject);
    }
}
}