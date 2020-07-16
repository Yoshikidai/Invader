using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addAudio : MonoBehaviour
{
  public GameObject FogParticle1;
  public GameObject FogParticle2;
  public GameObject AudioObject;

  public void OnClick()
  {
    Instantiate(
        FogParticle1,
        new Vector3(4f, -4f, -5f),
        transform.rotation
    );
    Instantiate(
        FogParticle2,
        new Vector3(-4f, -4f, -5f),
        transform.rotation
    );
    Instantiate(
        AudioObject,
        new Vector3(0f, 0f, -5f),
        transform.rotation
    );

  }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
