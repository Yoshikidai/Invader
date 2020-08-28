using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class numberController : MonoBehaviour
{
  public Text point;
  public Text destroyEnemy;
  public Text destroyPlayer;
  public Text winNumber;
  public Text loseNumber;

    // Start is called before the first frame update
    void Start()
    {

      point.text = string.Format("{0:#,0}", PlayerPrefs.GetInt("totalPoint", 0));
      destroyEnemy.text = string.Format("{0:#,0}", PlayerPrefs.GetInt("destroyEnemy", 0));
      destroyPlayer.text = string.Format("{0:#,0}", PlayerPrefs.GetInt("destroyPlayer", 0));
      winNumber.text = string.Format("{0:#,0}", PlayerPrefs.GetInt("winNumber", 0));
      loseNumber.text = string.Format("{0:#,0}", PlayerPrefs.GetInt("loseNumber", 0));

    }

    // Update is called once per frame
    void Update()
    {

    }
}
