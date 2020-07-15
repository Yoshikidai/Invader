using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
  public GameObject pausePanel;
  public GameObject unablePanel;

  public void OnClick()
  {
    Time.timeScale = 0.3f;
    pausePanel.SetActive(true);
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
