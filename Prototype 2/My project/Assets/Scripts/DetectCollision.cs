using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Work then rigid body hit collider with triggers
    private void OnTriggerEnter(Collider other)
    {
        //destroy animals and food on hit
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
