using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cancelQuit : MonoBehaviour
{
  public GameObject quitPanel;
  public GameObject unablePanel;

  public void OnClick()
  {
    unablePanel.SetActive(false);
    quitPanel.SetActive(false);

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
