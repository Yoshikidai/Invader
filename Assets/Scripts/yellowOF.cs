using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowOF : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      float dy = Time.deltaTime * 0.3f;

      transform.position = new Vector3(
        transform.position.x,
        transform.position.y + dy,
        0f
      );
    }
}
