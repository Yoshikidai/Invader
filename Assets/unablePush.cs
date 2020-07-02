using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unablePush : MonoBehaviour
{
  public GameObject unablePanel;
  float elapsedtime = 0;
  float timeLimit = 0.5f; //制限時間:1秒
  bool clicked = false;

  public void OnClick()
  {
    clicked = true;
    unablePanel.SetActive(true);

  }


    // Start is called before the first frame update
    void Start()
    {

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
        unablePanel.SetActive(false);
        elapsedtime = 0;
        clicked = false;

      }

    }
}
