using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueDFbutton3 : MonoBehaviour
{
  GameObject otherDF;
  public GameObject blueDF;
  GameObject button;
  public GameObject panel;

  public void OnClick()
  {
    otherDF = GameObject.FindWithTag("playerDF3");
    Destroy(otherDF);
    Instantiate(
        blueDF,
        new Vector3(button.transform.position.x, button.transform.position.y, 2f),
        transform.rotation
    ); //パーティクル用ゲームオブジェクト生成
    panel.SetActive(false);

  }

    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.FindWithTag("button3");
        blueDF.tag = "playerDF3";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
