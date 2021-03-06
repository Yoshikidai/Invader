using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whiteDFbutton2 : MonoBehaviour
{
  GameObject otherDF;
  public GameObject whiteDF;
  GameObject button;
  public GameObject panel;
  float elapsedtime=0;
  float timeLimit = 0.6f; //制限時間:1秒
  bool clicked = false;

  public void OnClick()
  {
    otherDF = GameObject.FindWithTag("playerDF2");
    Destroy(otherDF);
    Instantiate(
        whiteDF,
        new Vector3(button.transform.position.x, button.transform.position.y, 2f),
        transform.rotation
    ); //パーティクル用ゲームオブジェクト生成

    clicked = true;
  }

    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.FindWithTag("button2");
        whiteDF.tag = "playerDF2";
    }

    void Update()
    {
        if(clicked)
        {
          elapsedtime += Time.deltaTime; //経過時間
        }
        if (timeLimit < elapsedtime)
        {
          elapsedtime = 0;
          clicked = false;
          panel.SetActive(false);

        }
    }


}
