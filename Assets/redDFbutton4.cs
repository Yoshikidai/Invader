using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redDFbutton4 : MonoBehaviour
{
  GameObject otherDF;
  public GameObject redDF;
  GameObject button;
  public GameObject panel;

  public void OnClick()
  {
    otherDF = GameObject.FindWithTag("playerDF4");
    Destroy(otherDF);
    Instantiate(
        redDF,
        new Vector3(button.transform.position.x, button.transform.position.y, 2f),
        transform.rotation
    ); //パーティクル用ゲームオブジェクト生成
    panel.SetActive(false);

  }

    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.FindWithTag("button4");
        redDF.tag = "playerDF4";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
