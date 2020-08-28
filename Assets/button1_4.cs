using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class button1_4 : MonoBehaviour
{
  GameObject[] background;

    public void OnClick()
    {
      for(int i = 0; i < background.Length; ++i)
      {
        Destroy(background[i].gameObject);
      }

      SceneController.stage = "1_4";
    }
    // Start is called before the first frame update
    void Start()
    {
      background = GameObject.FindGameObjectsWithTag("background");

    }

    // Update is called once per frame
    void Update()
    {
      string clear = PlayerPrefs.GetString("1_4");
      if(clear == "clear")
      {
        Button button = this.GetComponent<Button>();
        ColorBlock cb = button.colors;
        cb.normalColor = new Color(0f, 1f, 0f, 0.5f);
        button.colors = cb;
      }

    }
}
