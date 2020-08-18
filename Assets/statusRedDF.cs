using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class statusRedDF : MonoBehaviour
{
  public Text beforeHP;
  public Text afterHP;
  public Text beforeATK;
  public Text afterATK;
  public Text beforeITV;
  public Text afterITV;
  public Text point;

  public GameObject HPButton;
  public GameObject ATKButton;
  public GameObject ITVButton;
  int possession;

  int HP1;
  int HP2;
  int ATK1;
  int ATK2;
  int ITV1;
  int ITV2;
  public static int Point;


  public static int getPoint()
  {
    return Point;

  }

    // Start is called before the first frame update
    void Start()
    {
      HP1 = PlayerPrefs.GetInt("RedDefenceHP", 300);
      ATK1 = PlayerPrefs.GetInt("RedDefenceATK", 300);
      ITV1 = PlayerPrefs.GetInt("RedDefenceITV", 300);
      Point = PlayerPrefs.GetInt("RedDefencePoint", 100);

      HP2 = Mathf.FloorToInt(HP1 * 1.1f);
      ATK2 = Mathf.RoundToInt(ATK1 * 1.05f);
      ITV2 = Mathf.RoundToInt(ITV1 * 0.95f);

      beforeHP.text = string.Format("{0:#,0}", HP1);
      beforeATK.text = string.Format("{0:#,0}", ATK1);
      beforeITV.text = string.Format("{0:#,0}", ITV1);

      afterHP.text = string.Format("{0:#,0}", HP2);
      afterATK.text = string.Format("{0:#,0}", ATK2);
      afterITV.text = string.Format("{0:#,0}", ITV2);

      point.text = string.Format("{0:#,0}", Point);

    }

    // Update is called once per frame
    void Update()
    {
      HP1 = PlayerPrefs.GetInt("RedDefenceHP", 300);
      ATK1 = PlayerPrefs.GetInt("RedDefenceATK", 300);
      ITV1 = PlayerPrefs.GetInt("RedDefenceITV", 300);
      Point = PlayerPrefs.GetInt("RedDefencePoint", 100);

      HP2 = Mathf.FloorToInt(HP1 * 1.1f);
      ATK2 = Mathf.RoundToInt(ATK1 * 1.05f);
      ITV2 = Mathf.RoundToInt(ITV1 * 0.95f);

      beforeHP.text = string.Format("{0:#,0}", HP1);
      beforeATK.text = string.Format("{0:#,0}", ATK1);
      beforeITV.text = string.Format("{0:#,0}", ITV1);

      afterHP.text = string.Format("{0:#,0}", HP2);
      afterATK.text = string.Format("{0:#,0}", ATK2);
      afterITV.text = string.Format("{0:#,0}", ITV2);

      point.text = string.Format("{0:#,0}", Point);

      possession = Possession.getPossession();

      if(possession >= Point)
      {
        HPButton.SetActive(true);
        ITVButton.SetActive(true);
        ATKButton.SetActive(true);

      }
      else
      {
        HPButton.SetActive(false);
        ITVButton.SetActive(false);
        ATKButton.SetActive(false);

      }


    }
}
