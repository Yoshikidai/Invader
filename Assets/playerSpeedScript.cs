using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSpeedScript : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      float dy = Time.deltaTime * speed * 0.1f;

      transform.position = new Vector3
      (
        transform.position.x,
        transform.position.y + dy,
        0f
      );
    }
}
