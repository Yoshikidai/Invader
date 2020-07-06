using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToQuit : MonoBehaviour
{
  public GameObject quitPanel;
  public GameObject unablePanel;

  public void OnClick()
  {
    quitPanel.SetActive(true);
    unablePanel.SetActive(true);

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
