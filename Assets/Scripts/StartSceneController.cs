using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartSceneController : MonoBehaviour
{
  public GameObject FogParticle1;
  public GameObject FogParticle2;
  public GameObject AudioObject;
  public GameObject panel;
  float speed = 0.03f;  //透明化の速さ
  float alfa;    //A値を操作するための変数
  float red, green, blue;    //RGBを操作するための変数
  bool clicked;
  public static bool start;

  public static bool getStart(){
    return start;
  }

    // Start is called before the first frame update
    void Start()
    {
      red = panel.GetComponent<Image>().color.r;
      green = panel.GetComponent<Image>().color.g;
      blue = panel.GetComponent<Image>().color.b;
      alfa = 1;

      clicked = false;
      start = true;
    }

    // Update is called once per frame
    void Update()
    {
      panel.GetComponent<Image>().color = new Color(red, green, blue, alfa);

      if(!clicked)
      {
        alfa -= speed;
        if(alfa < 0)
        {
          alfa = 0;
        }
      }

      if(alfa == 0)
      {
        if (Input.GetMouseButtonDown(0))
        {
          clicked = true;

        }

      }

      if(clicked)
      {
        alfa += speed;

      }

      if(alfa > 1)
      {
        SceneManager.LoadScene("ModeSelectScene");
        Instantiate(
            FogParticle1,
            new Vector3(4f, -4f, -5f),
            transform.rotation
        );
        Instantiate(
            FogParticle2,
            new Vector3(-4f, -4f, -5f),
            transform.rotation
        );
        Instantiate(
            AudioObject,
            new Vector3(0f, 0f, -5f),
            transform.rotation
        );

      }

    }
}
