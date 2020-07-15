using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fadeController : MonoBehaviour
{
  private bool start;
  float speed = 0.01f;  //透明化の速さ
  float alfa;    //A値を操作するための変数
  float red, green, blue;    //RGBを操作するための変数
  public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
      red = panel.GetComponent<Image>().color.r;
      green = panel.GetComponent<Image>().color.g;
      blue = panel.GetComponent<Image>().color.b;
      alfa = 1;

      start = StartSceneController.getStart();
      if(start)
      {
        alfa = 1;
        StartSceneController.start = false;
        panel.SetActive(true);
      }
      else
      {
        alfa = 0;
        panel.SetActive(false);
      }
    }

    // Update is called once per frame
    void Update()
    {
      panel.GetComponent<Image>().color = new Color(red, green, blue, alfa);
      alfa -= speed;
      
      if(alfa < 0)
      {
        panel.SetActive(false);

      }
    }
}
