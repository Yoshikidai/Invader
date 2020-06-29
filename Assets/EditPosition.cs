using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EditPosition : MonoBehaviour
{

  public GameObject emptyOFbox;
  public GameObject DFposition;

    // Start is called before the first frame update
    void Start()
    {

      Instantiate(
          emptyOFbox,
          new Vector3(-2f,transform.position.y,2f),
          transform.rotation
      );
      Instantiate(
          emptyOFbox,
          new Vector3(-1f,transform.position.y,2f),
          transform.rotation
      );
      Instantiate(
          emptyOFbox,
          new Vector3(0f,transform.position.y,2f),
          transform.rotation
      );
      Instantiate(
          emptyOFbox,
          new Vector3(1f,transform.position.y,2f),
          transform.rotation
      );
      Instantiate(
          emptyOFbox,
          new Vector3(2f,transform.position.y,2f),
          transform.rotation
      );
      Instantiate(
          emptyOFbox,
          new Vector3(-2f,-transform.position.y,2f),
          transform.rotation
      );
      Instantiate(
          emptyOFbox,
          new Vector3(-1f,-transform.position.y,2f),
          transform.rotation
      );
      Instantiate(
          emptyOFbox,
          new Vector3(0f,-transform.position.y,2f),
          transform.rotation
      );
      Instantiate(
          emptyOFbox,
          new Vector3(1f,-transform.position.y,2f),
          transform.rotation
      );
      Instantiate(
          emptyOFbox,
          new Vector3(2f,-transform.position.y,2f),
          transform.rotation
      );


      Instantiate(
          DFposition,
          new Vector3(-0.5f,-0.5f,3f),
          transform.rotation
      );
      Instantiate(
          DFposition,
          new Vector3(0.5f,-0.5f,3f),
          transform.rotation
      );
      Instantiate(
          DFposition,
          new Vector3(0f,-1.5f,3f),
          transform.rotation
      );
      Instantiate(
          DFposition,
          new Vector3(-1.5f,-2.5f,3f),
          transform.rotation
      );
      Instantiate(
          DFposition,
          new Vector3(0f,-2.5f,3f),
          transform.rotation
      );
      Instantiate(
          DFposition,
          new Vector3(1.5f,-2.5f,3f),
          transform.rotation
      );

    }

    // Update is called once per frame
    void Update()
    {

    }
}
