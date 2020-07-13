using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class button4_1 : MonoBehaviour
{
  GameObject[] background;

    public void OnClick()
    {
      for(int i = 0; i < background.Length; ++i)
      {
        Destroy(background[i].gameObject);
      }

      SceneController.stage = "4_1";
    }
    // Start is called before the first frame update
    void Start()
    {
      background = GameObject.FindGameObjectsWithTag("background");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
