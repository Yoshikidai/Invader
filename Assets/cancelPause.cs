using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cancelPause : MonoBehaviour
{
  public GameObject pausePanel;
  public GameObject unablePanel;

  public void OnClick()
  {
    Time.timeScale = 1;

    unablePanel.SetActive(false);
    pausePanel.SetActive(false);

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
