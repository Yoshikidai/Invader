using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NCMB;
using System.Linq;

public class statusBlackDF : MonoBehaviour
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
      //TestClassからデータを取得する
      NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject> ("BlackDFstatus");

      //データを検索し取得
      query.FindAsync ((List<NCMBObject> objectList, NCMBException e) => {

        //取得失敗
        if(e != null){
          //エラーコード表示
          Debug.Log(e.ToString());
          return;
        }

        //取得した全データのmessageを表示
        foreach (NCMBObject ncmbObject in objectList) {
          HP1 = System.Convert.ToInt32(ncmbObject["HP"]);
          ATK1 = System.Convert.ToInt32(ncmbObject["ATK"]);
          ITV1 = System.Convert.ToInt32(ncmbObject["ITV"]);
          Point = System.Convert.ToInt32(ncmbObject["Point"]);
        }
      });

      HP2 = Mathf.FloorToInt(HP1 * 1.1f);
      ATK2 = Mathf.FloorToInt(ATK1 * 1.05f);
      ITV2 = Mathf.FloorToInt(ITV1 * 0.95f);

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

      possession = Possession.getPossession();

      if(possession >= Point)
      {
        HPButton.SetActive(true);
        ATKButton.SetActive(true);
        ITVButton.SetActive(true);

      }
      else
      {
        HPButton.SetActive(false);
        ATKButton.SetActive(false);
        ITVButton.SetActive(false);

      }

    }
}
