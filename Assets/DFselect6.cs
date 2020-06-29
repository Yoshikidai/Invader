using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DFselect6 : MonoBehaviour
{
  GameObject[] objects;
  public GameObject panel;
  GameObject otherDF;

  public void OnClick()
  {
    otherDF = GameObject.FindWithTag("playerDF6");
    Destroy(otherDF);
    panel.SetActive(true);

  }

    // Start is called before the first frame update
    void Start()
    {
      objects = GameObject.FindGameObjectsWithTag("DFposition");
      transform.position = objects[5].transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
