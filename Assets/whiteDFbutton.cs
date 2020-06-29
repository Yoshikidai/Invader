﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whiteDFbutton : MonoBehaviour
{
  GameObject otherDF;
  public GameObject whiteDF;
  GameObject button;
  public GameObject panel;

  public void OnClick()
  {
    otherDF = GameObject.FindWithTag("playerDF1");
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
        button = GameObject.FindWithTag("button1");
        whiteDF.tag = "playerDF1";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
