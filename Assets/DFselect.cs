using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DFselect : MonoBehaviour
{
  GameObject[] objects;

    // Start is called before the first frame update
    void Start()
    {
      objects = GameObject.FindGameObjectsWithTag("DFposition");
      transform.position = objects[1].transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
