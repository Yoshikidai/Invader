using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackDFbutton2 : MonoBehaviour
{
  GameObject otherDF;
  public GameObject blackDF;
  GameObject button;
  public GameObject panel;

  public void OnClick()
  {
    otherDF = GameObject.FindWithTag("playerDF2");
    Destroy(otherDF);
    Instantiate(
        blackDF,
        new Vector3(button.transform.position.x, button.transform.position.y, 2f),
        transform.rotation
    ); //パーティクル用ゲームオブジェクト生成
    panel.SetActive(false);

  }

    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.FindWithTag("button2");
        blackDF.tag = "playerDF2";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
