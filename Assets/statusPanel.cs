using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class statusPanel : MonoBehaviour
{
  public GameObject Panel;
  GameObject otherPanel;

  public void OnClick()
  {
    otherPanel = GameObject.FindWithTag("panel");
    otherPanel.SetActive(false);
    Panel.SetActive(true);

  }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
