using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whiteDFbutton3 : MonoBehaviour
{
  GameObject otherDF;
  public GameObject whiteDF;
  GameObject button;
  public GameObject panel;

  public void OnClick()
  {
    otherDF = GameObject.FindWithTag("playerDF3");
    Destroy(otherDF);
    Instantiate(
        whiteDF,
        new Vector3(button.transform.position.x, button.transform.position.y, 2f),
        transform.rotation
    ); //パーティクル用ゲームオブジェクト生成
    panel.SetActive(false);

  }

    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.FindWithTag("button3");
        whiteDF.tag = "playerDF3";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
