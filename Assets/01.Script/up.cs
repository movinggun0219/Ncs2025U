using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class up : MonoBehaviour
{
    float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveUpAfterDelay());
    }

   
    IEnumerator MoveUpAfterDelay()
    {
        yield return new WaitForSeconds(3f); 
        transform.position += Vector3.up* speed;
    }
}
