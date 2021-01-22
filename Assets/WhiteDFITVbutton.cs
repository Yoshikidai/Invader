using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WhiteDFITVbutton : MonoBehaviour
{

  public static int ITV;
  public static int Point;
  public Text beforeITVText;
  public Text afterITVText;
  public Text pointText;
  int possession;
  public Text possessionText;

  public void OnClick()
  {
      possession = PlayerPrefs.GetInt("possession", 1000);
      ITV = PlayerPrefs.GetInt("WhiteDefenceITV", 300);
      Point = PlayerPrefs.GetInt("WhiteDefencePoint", 100);

      possession = possession - Point;

      PlayerPrefs.SetInt("WhiteDefenceITV", Mathf.FloorToInt(ITV * 0.95f));
      PlayerPrefs.SetInt("WhiteDefencePoint", Mathf.FloorToInt(Point * 1.5f));
      PlayerPrefs.SetInt("possession", possession);

      PlayerPrefs.Save();

      beforeITVText.text = string.Format("{0:#,0}", ITV);
      afterITVText.text = string.Format("{0:#,0}", Mathf.FloorToInt(ITV * 0.95f));
      pointText.text = string.Format("{0:#,0}", Mathf.FloorToInt(Point * 1.5f));

      Possession.possession = possession;
      possessionText.text = string.Format("{0:#,0}", possession);

  }

    // Start is called before the first frame update
    void Start()
    {
      possession = Possession.getPossession();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
