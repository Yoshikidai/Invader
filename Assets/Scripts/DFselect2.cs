using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DFselect2 : MonoBehaviour
{
  GameObject DFposition;
  public GameObject panel;
  GameObject[] otherDFs;
  float elapsedtime = 0;
  float timeLimit = 0.3f; //制限時間:2秒
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
      otherDFs = GameObject.FindGameObjectsWithTag("playerDF2");
      DFposition = GameObject.FindWithTag("DFposition2");
      transform.position = new Vector3
      (
        DFposition.transform.position.x,
        DFposition.transform.position.y,
        -3f
      );
      DFposition.SetActive(false);

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
