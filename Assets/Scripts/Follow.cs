using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject parent;
    public GameObject child;

    void Update()
    {
        child.transform.position = parent.transform.position;
    }
}
