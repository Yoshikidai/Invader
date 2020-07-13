using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage4_1 : MonoBehaviour
{

  public GameObject enemyDF1;
  public GameObject enemyDF2;

    // Start is called before the first frame update
    void Start()
    {
      Instantiate(
          enemyDF1,
          new Vector3(-1f,2.5f,0f),
          transform.rotation
      );
      Instantiate(
          enemyDF2,
          new Vector3(1f,2.5f,0f),
          transform.rotation
      );

    }

    // Update is called once per frame
    void Update()
    {

    }
}
