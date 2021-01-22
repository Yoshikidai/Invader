using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class STAGE1Button : MonoBehaviour
{

    public void OnClick()
    {
      SceneController.stageNumber = 1;
      SceneManager.LoadScene("STAGE1");
    }
    // Start is called before the first frame update
    void Start()
    {
      string clear1 = PlayerPrefs.GetString("1_1");
      string clear2 = PlayerPrefs.GetString("1_2");
      string clear3 = PlayerPrefs.GetString("1_3");
      string clear4 = PlayerPrefs.GetString("1_4");
      string clear5 = PlayerPrefs.GetString("1_5");
      string clearBoss = PlayerPrefs.GetString("1_boss");
      if((clear1 == "clear")&&(clear2 == "clear")&&(clear3 == "clear")&&(clear4 == "clear")&&(clear5 == "clear")&&(clearBoss == "clear"))
      {
        Button button = this.GetComponent<Button>();
        ColorBlock cb = button.colors;
        cb.normalColor = new Color(0f, 1f, 0f, 0.5f);
        button.colors = cb;
        PlayerPrefs.SetString("stage1", "clear");

      }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
