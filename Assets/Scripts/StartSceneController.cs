using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartSceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      FadeManager.FadeIn();
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButtonDown(0))
      {
        SceneManager.LoadScene("ModeSelectScene");
      }

    }
}
