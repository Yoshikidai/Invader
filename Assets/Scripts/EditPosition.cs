using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EditPosition : MonoBehaviour
{

  public GameObject emptyOFbox;
  public GameObject DFposition1;
  public GameObject DFposition2;
  public GameObject DFposition3;
  public GameObject DFposition4;
  public GameObject DFposition5;
  public GameObject DFposition6;

    // Start is called before the first frame update
    void Start()
    {
      DFposition1.SetActive(true);
      DFposition2.SetActive(true);
      DFposition3.SetActive(true);
      DFposition4.SetActive(true);
      DFposition5.SetActive(true);
      DFposition6.SetActive(true);

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
          DFposition1,
          new Vector3(-0.5f,-0.5f,3f),
          transform.rotation
      );
      Instantiate(
          DFposition2,
          new Vector3(0.5f,-0.5f,3f),
          transform.rotation
      );
      Instantiate(
          DFposition3,
          new Vector3(0f,-1.5f,3f),
          transform.rotation
      );
      Instantiate(
          DFposition4,
          new Vector3(-1.5f,-2.5f,3f),
          transform.rotation
      );
      Instantiate(
          DFposition5,
          new Vector3(0f,-2.5f,3f),
          transform.rotation
      );
      Instantiate(
          DFposition6,
          new Vector3(1.5f,-2.5f,3f),
          transform.rotation
      );

    }

    // Update is called once per frame
    void Update()
    {

    }
}
