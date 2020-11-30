using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name +"Touch me");
        Time.timeScale = 0;
    }
}
