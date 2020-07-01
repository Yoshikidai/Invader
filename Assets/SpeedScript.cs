using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedScript : MonoBehaviour
{

    public float speed;
    public float dy;

    // Start is called before the first frame update
    void Start()
    {
      dy = speed * 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3
        (
          transform.position.x,
          transform.position.y + dy,
          0f
        );
    }
}
