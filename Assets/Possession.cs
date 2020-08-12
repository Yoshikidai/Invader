using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NCMB;
using System.Linq;

public class Possession : MonoBehaviour
{
  public static int possession;
  string possessionString;
  public Text possessionText;

  public static int getPossession()
  {
    return possession;
  }

    // Start is called before the first frame update
    void Start()
    {
      //TestClassからデータを取得する
      NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject> ("possession");

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
          possession = System.Convert.ToInt32(ncmbObject["Point"]);
        }
      });

      possessionString = string.Format("{0:#,0}", possession);
      possessionText.text = possessionString;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
