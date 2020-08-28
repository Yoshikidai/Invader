using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class button3_2 : MonoBehaviour
{
  GameObject[] background;

    public void OnClick()
    {
      for(int i = 0; i < background.Length; ++i)
      {
        Destroy(background[i].gameObject);
      }

      SceneController.stage = "3_2";
    }
    // Start is called before the first frame update
    void Start()
    {
      background = GameObject.FindGameObjectsWithTag("background");

    }

    // Update is called once per frame
    void Update()
    {
      string clear = PlayerPrefs.GetString("3_2");
      if(clear == "clear")
      {
        Button button = this.GetComponent<Button>();
        ColorBlock cb = button.colors;
        cb.normalColor = new Color(0f, 1f, 0f, 0.5f);
        button.colors = cb;
      }

    }
}
