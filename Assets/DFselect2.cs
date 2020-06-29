using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DFselect2 : MonoBehaviour
{
  GameObject[] objects;
  public GameObject panel;
  GameObject otherDF;

  public void OnClick()
  {
    otherDF = GameObject.FindWithTag("playerDF2");
    Destroy(otherDF);
    panel.SetActive(true);
  }

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
