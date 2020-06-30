using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DFselect2 : MonoBehaviour
{
  GameObject[] objects;
  public GameObject panel;
  GameObject[] otherDFs;

  public void OnClick()
  {
    for(int i = 0; i < otherDFs.Length; ++i)
    {
      Destroy(otherDFs[i].gameObject);
    }

    panel.SetActive(true);
  }

    // Start is called before the first frame update
    void Start()
    {
      otherDFs = GameObject.FindGameObjectsWithTag("playerDF2");
      objects = GameObject.FindGameObjectsWithTag("DFposition");
      transform.position = new Vector3
      (
        objects[1].transform.position.x,
        objects[1].transform.position.y,
        -3f
      );
    }

    // Update is called once per frame
    void Update()
    {

    }
}
