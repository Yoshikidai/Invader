using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NCMB;
using System.Linq;

public class WhiteDFITVbutton : MonoBehaviour
{

  public static int ITV;
  public static int Point;
  public Text beforeITVText;
  public Text afterITVText;
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
      NCMBQuery<NCMBObject> query2 = new NCMBQuery<NCMBObject> ("WhiteDFstatus");

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
          ITV = System.Convert.ToInt32(ncmbObject["ITV"]);
        }
        foreach (NCMBObject ncmbObject in objectList) {
          Point = System.Convert.ToInt32(ncmbObject["Point"]);
        }

        foreach (NCMBObject ncmbObject in objectList) {
          obj1 = ncmbObject;
        }
      });

      possession = possession - Point;

      obj2 = new NCMBObject ("WhiteDFstatus");
      obj2.ObjectId = obj1.ObjectId;
      obj2["ITV"] = Mathf.FloorToInt(ITV * 1.05f);
      obj2["Point"] = Mathf.FloorToInt(Point * 1.5f);

      obj2.SaveAsync();

      beforeITVText.text = string.Format("{0:#,0}", ITV);
      afterITVText.text = string.Format("{0:#,0}", Mathf.FloorToInt(ITV * 1.05f));
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
