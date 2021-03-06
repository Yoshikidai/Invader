using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NCMB;
using System.Linq;

public class BlueDFHPbutton : MonoBehaviour
{

  public static int HP;
  public static int Point;
  public Text beforeHPText;
  public Text afterHPText;
  public Text pointText;
  int possession;
  public Text possessionText;
  NCMBObject obj1;
  NCMBObject obj2;

  public void OnClick()
  {
      //TestClassからデータを取得する
      NCMBQuery<NCMBObject> query1 = new NCMBQuery<NCMBObject> ("possession");

      //データを検索し取得
      query1.FindAsync ((List<NCMBObject> objectList, NCMBException e) => {

        //取得失敗
        if(e != null){
          //エラーコード表示
          Debug.Log(e.ToString());
          return;
        }

        //取得した全データのmessageを表示
        foreach (NCMBObject ncmbObject in objectList) {
          possession = System.Convert.ToInt32(ncmbObject["Point"]);
        }
      });


      //TestClassからデータを取得する
      NCMBQuery<NCMBObject> query2 = new NCMBQuery<NCMBObject> ("BlueDFstatus");

      //データを検索し取得
      query2.FindAsync ((List<NCMBObject> objectList, NCMBException e) => {

        //取得失敗
        if(e != null){
          //エラーコード表示
          Debug.Log(e.ToString());
          return;
        }

        //取得した全データのmessageを表示
        foreach (NCMBObject ncmbObject in objectList) {
          HP = System.Convert.ToInt32(ncmbObject["HP"]);
        }
        foreach (NCMBObject ncmbObject in objectList) {
          Point = System.Convert.ToInt32(ncmbObject["Point"]);
        }

        foreach (NCMBObject ncmbObject in objectList) {
          obj1 = ncmbObject;
        }
      });

      possession = possession - Point;

      obj2 = new NCMBObject ("BlueDFstatus");
      obj2.ObjectId = obj1.ObjectId;
      obj2["HP"] = Mathf.FloorToInt(HP * 1.05f);
      obj2["Point"] = Mathf.FloorToInt(Point * 1.5f);

      obj2.SaveAsync();

      beforeHPText.text = string.Format("{0:#,0}", HP);
      afterHPText.text = string.Format("{0:#,0}", Mathf.FloorToInt(HP * 1.05f));
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
