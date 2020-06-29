using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DFselect1 : MonoBehaviour
{
  GameObject[] objects;
  public GameObject panel;
  GameObject otherDF;

  public void OnClick()
  {
    otherDF = GameObject.FindWithTag("playerDF1");
    Destroy(otherDF);

    panel.SetActive(true);
  }

    // Start is called before the first frame update
    void Start()
    {
      objects = GameObject.FindGameObjectsWithTag("DFposition");
      transform.position = new Vector3
      (
        objects[0].transform.position.x,
        objects[0].transform.position.y,
        -3f
      );
    }

    // Update is called once per frame
    void Update()
    {

    }
}
