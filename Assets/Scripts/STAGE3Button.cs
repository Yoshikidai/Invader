using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class STAGE3Button : MonoBehaviour
{

    public void OnClick()
    {
      SceneManager.LoadScene("STAGE3");
    }
    // Start is called before the first frame update
    void Start()
    {
      string clear1 = PlayerPrefs.GetString("3_1");
      string clear2 = PlayerPrefs.GetString("3_2");
      string clear3 = PlayerPrefs.GetString("3_3");
      string clear4 = PlayerPrefs.GetString("3_4");
      string clear5 = PlayerPrefs.GetString("3_5");
      string clearBoss = PlayerPrefs.GetString("3_boss");
      if((clear1 == "clear")&&(clear2 == "clear")&&(clear3 == "clear")&&(clear4 == "clear")&&(clear5 == "clear")&&(clearBoss == "clear"))
      {
        Button button = this.GetComponent<Button>();
        ColorBlock cb = button.colors;
        cb.normalColor = new Color(0f, 1f, 0f, 0.5f);
        button.colors = cb;
        PlayerPrefs.SetString("stage3", "clear");

      }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
