using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DFselect3 : MonoBehaviour
{
  GameObject[] objects;
  public GameObject panel;
  GameObject[] otherDFs;
  float elapsedtime = 0;
  float timeLimit = 0.3f; //制限時間:1秒
  bool clicked = false;

  public void OnClick()
  {
    for(int i = 0; i < otherDFs.Length; ++i)
    {
      Destroy(otherDFs[i].gameObject);
    }

    clicked = true;
  }

    // Start is called before the first frame update
    void Start()
    {
      otherDFs = GameObject.FindGameObjectsWithTag("playerDF3");
      objects = GameObject.FindGameObjectsWithTag("DFposition");
      transform.position = new Vector3
      (
        objects[2].transform.position.x,
        objects[2].transform.position.y,
        -3f
      );
    }

    // Update is called once per frame
    void Update()
    {
      if(clicked)
      {
        elapsedtime += Time.deltaTime; //経過時間
      }

      if (timeLimit < elapsedtime)
      {
        panel.SetActive(true);
        elapsedtime = 0;
        clicked = false;

      }

    }
}
