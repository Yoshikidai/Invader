using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartSceneController : MonoBehaviour
{
  public GameObject FogParticle1;
  public GameObject FogParticle2;
  public GameObject AudioObject;

    // Start is called before the first frame update
    void Start()
    {
      FadeManager.FadeIn();
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButtonDown(0))
      {
        SceneManager.LoadScene("ModeSelectScene");
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

    }
}
