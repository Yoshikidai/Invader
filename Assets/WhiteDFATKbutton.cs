using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NCMB;
using System.Linq;

public class WhiteDFATKbutton : MonoBehaviour
{

  public static int ATK;
  public static int Point;
  public Text beforeATKText;
  public Text afterATKText;
  public Text pointText;
  int possession;
  public Text possessionText;

  public void OnClick()
  {
      possession = PlayerPrefs.GetInt("possession", 0);
      ATK = PlayerPrefs.GetInt("WhiteDefenceATK", 300);
      Point = PlayerPrefs.GetInt("WhiteDefencePoint", 100);

      possession = possession - Point;

      PlayerPrefs.SetInt("WhiteDefenceATK", Mathf.FloorToInt(ATK * 1.05f));
      PlayerPrefs.SetInt("WhiteDefencePoint", Mathf.FloorToInt(Point * 1.5f));
      PlayerPrefs.SetInt("possession", possession);

      PlayerPrefs.Save();

      beforeATKText.text = string.Format("{0:#,0}", ATK);
      afterATKText.text = string.Format("{0:#,0}", Mathf.FloorToInt(ATK * 1.05f));
      pointText.text = string.Format("{0:#,0}", Mathf.FloorToInt(Point * 1.2f));

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
