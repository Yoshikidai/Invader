using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class statusWhiteOF : MonoBehaviour
{
  public Text beforeHitPoint;
  public Text afterHitPoint;
  public Text beforeAttack;
  public Text afterAttack;
  public Text beforeInterval;
  public Text afterInterval;
  public Text point1;
  public Text point2;
  public Text point3;

  public GameObject HitPointButton;
  public GameObject AttackButton;
  public GameObject IntervalButton;
  int possession;

  int HitPoint1;
  int HitPoint2;
  int Attack1;
  int Attack2;
  int Interval1;
  int Interval2;
  int Point1;
  int Point2;
  int Point3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      HitPoint1 = CryptoPlayerPrefs.GetInt ("whiteOFHitPoint", 300);
      Attack1 = CryptoPlayerPrefs.GetInt ("whiteOFAttack", 300);
      Interval1 = CryptoPlayerPrefs.GetInt ("whiteOFInterval", 300);

      HitPoint2 = Mathf.FloorToInt(HitPoint1 * 1.1f);
      Attack2 = Mathf.FloorToInt(Attack1 * 1.05f);
      Interval2 = Mathf.FloorToInt(Interval1 * 0.95f);

      beforeHitPoint.text = string.Format("{0:#,0}", HitPoint1);
      beforeAttack.text = string.Format("{0:#,0}", Attack1);
      beforeInterval.text = string.Format("{0:#,0}", Interval1);

      afterHitPoint.text = string.Format("{0:#,0}", HitPoint2);
      afterAttack.text = string.Format("{0:#,0}", Attack2);
      afterInterval.text = string.Format("{0:#,0}", Interval2);

      Point1 = CryptoPlayerPrefs.GetInt ("whiteOFpoint1", 50);
      Point2 = CryptoPlayerPrefs.GetInt ("whiteOFpoint2", 50);
      Point3 = CryptoPlayerPrefs.GetInt ("whiteOFpoint3", 50);

      point1.text = string.Format("{0:#,0}", Point1);
      point2.text = string.Format("{0:#,0}", Point2);
      point3.text = string.Format("{0:#,0}", Point3);

      possession = Possession.getPossession();

      if(possession >= Point1)
      {
        HitPointButton.SetActive(true);

      }
      else
      {
        HitPointButton.SetActive(false);

      }

      if(possession >= Point2)
      {
        AttackButton.SetActive(true);

      }
      else
      {
        AttackButton.SetActive(false);

      }

      if(possession >= Point3)
      {
        IntervalButton.SetActive(true);

      }
      else
      {
        IntervalButton.SetActive(false);

      }


    }
}
