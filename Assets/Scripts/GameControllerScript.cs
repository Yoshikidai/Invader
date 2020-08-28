using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using NCMB;
using System.Linq;


public class GameControllerScript : MonoBehaviour
{
  public GameObject particleObject1;

  public GameObject playerOFbox1;
  public GameObject playerOFbox2;
  public GameObject playerOFbox3;
  public GameObject playerOFbox4;

  public GameObject particleObject2;

  GameObject enemyOFbox1;
  GameObject enemyOFbox2;
  GameObject enemyOFbox3;
  GameObject enemyOFbox4;

  GameObject[] emptyOFbox;

  public GameObject FogParticle1;
  public GameObject FogParticle2;
  public GameObject AudioObject;

  public Text ReplayText;
  public Text ResultText;
  public bool isVictory;
  public bool isDefeat;
  GameObject[] DF1;
  GameObject[] DF2;
  GameObject[] DF3;
  GameObject[] DF4;
  GameObject[] DF5;
  GameObject[] DF6;

  public int playerBoxNumber;
  public int enemyBoxNumber;

  private string stageName;

  public GameObject unablePanel;
  public GameObject pausePanel;

  int beforePossession;
  int afterPossession;
  NCMBObject obj1;
  NCMBObject obj2;
  public Text Possession1;
  public Text Possession2;
  public Text PossessionText;
  public Text right;

  // Start is called before the first frame update
  void Start()
  {
    stageName = SceneController.getStage();

    enemyBoxNumber = EditPosition.getEnemyBoxNumber();

    if(enemyBoxNumber == 1)
    {
      enemyOFbox2 = GameObject.FindWithTag("enemyBox2");
      enemyOFbox3 = GameObject.FindWithTag("enemyBox3");
      enemyOFbox4 = GameObject.FindWithTag("enemyBox4");

      enemyOFbox2.GetComponent<enemyBlackBox>().enabled = true;
      enemyOFbox3.GetComponent<enemyWhiteBox>().enabled = true;
      enemyOFbox4.GetComponent<enemyBlueBox>().enabled = true;

    }
    else if(enemyBoxNumber == 2)
    {
      enemyOFbox1 = GameObject.FindWithTag("enemyBox1");
      enemyOFbox3 = GameObject.FindWithTag("enemyBox3");
      enemyOFbox4 = GameObject.FindWithTag("enemyBox4");

      enemyOFbox1.GetComponent<enemyRedBox>().enabled = true;
      enemyOFbox3.GetComponent<enemyWhiteBox>().enabled = true;
      enemyOFbox4.GetComponent<enemyBlueBox>().enabled = true;

    }
    else if(enemyBoxNumber == 3)
    {
      enemyOFbox1 = GameObject.FindWithTag("enemyBox1");
      enemyOFbox2 = GameObject.FindWithTag("enemyBox2");
      enemyOFbox4 = GameObject.FindWithTag("enemyBox4");

      enemyOFbox1.GetComponent<enemyRedBox>().enabled = true;
      enemyOFbox2.GetComponent<enemyBlackBox>().enabled = true;
      enemyOFbox4.GetComponent<enemyBlueBox>().enabled = true;

    }
    else if(enemyBoxNumber == 4)
    {
      enemyOFbox1 = GameObject.FindWithTag("enemyBox1");
      enemyOFbox2 = GameObject.FindWithTag("enemyBox2");
      enemyOFbox3 = GameObject.FindWithTag("enemyBox3");

      enemyOFbox1.GetComponent<enemyRedBox>().enabled = true;
      enemyOFbox2.GetComponent<enemyBlackBox>().enabled = true;
      enemyOFbox3.GetComponent<enemyWhiteBox>().enabled = true;

    }


    playerBoxNumber = Random.Range(1, 5);

    if(playerBoxNumber == 1)
    {
      Instantiate(
          playerOFbox2,
          new Vector3(-2f,transform.position.y,1f),
          transform.rotation
      );
      Instantiate(
          playerOFbox3,
          new Vector3(0f,transform.position.y,1f),
          transform.rotation
      );
      Instantiate(
          playerOFbox4,
          new Vector3(2f,transform.position.y,1f),
          transform.rotation
      );

    }
    else if(playerBoxNumber == 2)
    {
      Instantiate(
          playerOFbox1,
          new Vector3(-2f,transform.position.y,1f),
          transform.rotation
      );
      Instantiate(
          playerOFbox3,
          new Vector3(0f,transform.position.y,1f),
          transform.rotation
      );
      Instantiate(
          playerOFbox4,
          new Vector3(2f,transform.position.y,1f),
          transform.rotation
      );

    }
    else if(playerBoxNumber == 3)
    {
      Instantiate(
          playerOFbox1,
          new Vector3(-2f,transform.position.y,1f),
          transform.rotation
      );
      Instantiate(
          playerOFbox2,
          new Vector3(0f,transform.position.y,1f),
          transform.rotation
      );
      Instantiate(
          playerOFbox4,
          new Vector3(2f,transform.position.y,1f),
          transform.rotation
      );

    }
    else if(playerBoxNumber == 4)
    {
      Instantiate(
          playerOFbox1,
          new Vector3(-2f,transform.position.y,1f),
          transform.rotation
      );
      Instantiate(
          playerOFbox2,
          new Vector3(0f,transform.position.y,1f),
          transform.rotation
      );
      Instantiate(
          playerOFbox3,
          new Vector3(2f,transform.position.y,1f),
          transform.rotation
      );

    }


    ResultText.text = "";
    ReplayText.text = "";
    Possession1.text = "";
    Possession2.text = "";
    PossessionText.text = "";
    right.text = "";
    isVictory = false;
    isDefeat = false;

    emptyOFbox = GameObject.FindGameObjectsWithTag("emptyBox");

    DF1 = GameObject.FindGameObjectsWithTag("playerDF1");
    DF2 = GameObject.FindGameObjectsWithTag("playerDF2");
    DF3 = GameObject.FindGameObjectsWithTag("playerDF3");
    DF4 = GameObject.FindGameObjectsWithTag("playerDF4");
    DF5 = GameObject.FindGameObjectsWithTag("playerDF5");
    DF6 = GameObject.FindGameObjectsWithTag("playerDF6");

    beforePossession = PlayerPrefs.GetInt ("possession", 0);

    if(stageName == "1_1" || stageName == "2_1" || stageName == "3_1" || stageName == "4_1")
    {
      afterPossession = beforePossession + 50;

    }
    if(stageName == "1_2" || stageName == "2_2" || stageName == "3_2" || stageName == "4_2")
    {
      afterPossession = beforePossession + 100;

    }
    if(stageName == "1_3" || stageName == "2_3" || stageName == "3_3" || stageName == "4_3")
    {
      afterPossession = beforePossession + 150;

    }
    if(stageName == "1_4" || stageName == "2_4" || stageName == "3_4" || stageName == "4_4")
    {
      afterPossession = beforePossession + 200;

    }
    if(stageName == "1_5" || stageName == "2_5" || stageName == "3_5" || stageName == "4_5")
    {
      afterPossession = beforePossession + 250;

    }
    if(stageName == "1_boss" || stageName == "2_boss" || stageName == "3_boss" || stageName == "4_boss")
    {
      afterPossession = beforePossession + 300;

    }

  }

  // Update is called once per frame
  void Update()
  {
    if ((!isVictory)&&(!isDefeat))
    {
      return;
    }

    if((isVictory == true)&&(isDefeat == true))
    {
      Draw();
    }

    if (Input.GetMouseButtonDown(0))
    {

      for(int i = 0; i < emptyOFbox.Length; ++i)
      {
        Destroy(emptyOFbox[i].gameObject);
      }

      // 指定したオブジェクトを削除
      for(int i = 0; i < DF1.Length; ++i)
      {
        Destroy(DF1[i].gameObject);
      }
      for(int i = 0; i < DF2.Length; ++i)
      {
        Destroy(DF2[i].gameObject);
      }
      for(int i = 0; i < DF3.Length; ++i)
      {
        Destroy(DF3[i].gameObject);
      }
      for(int i = 0; i < DF4.Length; ++i)
      {
        Destroy(DF4[i].gameObject);
      }
      for(int i = 0; i < DF5.Length; ++i)
      {
        Destroy(DF5[i].gameObject);
      }
      for(int i = 0; i < DF6.Length; ++i)
      {
        Destroy(DF6[i].gameObject);
      }

      Destroy(enemyOFbox1);
      Destroy(enemyOFbox2);
      Destroy(enemyOFbox3);
      Destroy(enemyOFbox4);

      Instantiate(
          FogParticle1,
          new Vector3(4f, -4f, -5f),
          transform.rotation
      );
      Instantiate(
          FogParticle2,
          new Vector3(-4f, -4f, -5f),
          transform.rotation
      );
      Instantiate(
          AudioObject,
          new Vector3(0f, 0f, -5f),
          transform.rotation
      );

      if(stageName == "1_1" || stageName == "1_2" || stageName == "1_3" || stageName == "1_4" || stageName == "1_5"
      || stageName == "1_boss")
      {
        SceneManager.LoadScene("STAGE1");
      }

      if(stageName == "2_1" || stageName == "2_2" || stageName == "2_3" || stageName == "2_4" || stageName == "2_5"
      || stageName == "2_boss")
      {
        SceneManager.LoadScene("STAGE2");
      }

      if(stageName == "3_1" || stageName == "3_2" || stageName == "3_3" || stageName == "3_4" || stageName == "3_5"
      || stageName == "3_boss")
      {
        SceneManager.LoadScene("STAGE3");
      }

      if(stageName == "4_1" || stageName == "4_2" || stageName == "4_3" || stageName == "4_4" || stageName == "4_5"
      || stageName == "4_boss")
      {
        SceneManager.LoadScene("STAGE4");
      }

    }

  }

  public void Win()
  {
    isVictory = true;
    unablePanel.SetActive(true);
    pausePanel.SetActive(false);
    ResultText.text = "You win!";
    ReplayText.text = "Tap screen to end this game";

    PlayerPrefs.SetInt ("possession", afterPossession);
    PlayerPrefs.SetInt("totalPoint", PlayerPrefs.GetInt("totalPoint", 0) + afterPossession - beforePossession);
    PlayerPrefs.Save ();

    PossessionText.text = "POSSESSION";
    right.text = "→";
    Possession1.text = string.Format("{0:#,0}", beforePossession);
    Possession2.text = string.Format("{0:#,0}", afterPossession);

    PlayerPrefs.SetInt("winNumber", PlayerPrefs.GetInt("winNumber", 0) + 1);
    PlayerPrefs.Save();

    if(stageName == "1_1")
    {
      PlayerPrefs.SetString("1_1", "clear");
      PlayerPrefs.Save();
    }
    if(stageName == "1_2")
    {
      PlayerPrefs.SetString("1_2", "clear");
      PlayerPrefs.Save();
    }
    if(stageName == "1_3")
    {
      PlayerPrefs.SetString("1_3", "clear");
      PlayerPrefs.Save();
    }
    if(stageName == "1_4")
    {
      PlayerPrefs.SetString("1_4", "clear");
      PlayerPrefs.Save();
    }
    if(stageName == "1_5")
    {
      PlayerPrefs.SetString("1_5", "clear");
      PlayerPrefs.Save();
    }
    if(stageName == "1_boss")
    {
      PlayerPrefs.SetString("1_boss", "clear");
      PlayerPrefs.Save();
    }
    if(stageName == "2_1")
    {
      PlayerPrefs.SetString("2_1", "clear");
      PlayerPrefs.Save();
    }
    if(stageName == "2_2")
    {
      PlayerPrefs.SetString("2_2", "clear");
      PlayerPrefs.Save();
    }
    if(stageName == "2_3")
    {
      PlayerPrefs.SetString("2_3", "clear");
      PlayerPrefs.Save();
    }
    if(stageName == "2_4")
    {
      PlayerPrefs.SetString("2_4", "clear");
      PlayerPrefs.Save();
    }
    if(stageName == "2_5")
    {
      PlayerPrefs.SetString("2_5", "clear");
      PlayerPrefs.Save();
    }
    if(stageName == "2_boss")
    {
      PlayerPrefs.SetString("2_boss", "clear");
      PlayerPrefs.Save();
    }
    if(stageName == "3_1")
    {
      PlayerPrefs.SetString("3_1", "clear");
      PlayerPrefs.Save();
    }
    if(stageName == "3_2")
    {
      PlayerPrefs.SetString("3_2", "clear");
      PlayerPrefs.Save();
    }
    if(stageName == "3_3")
    {
      PlayerPrefs.SetString("3_3", "clear");
      PlayerPrefs.Save();
    }
    if(stageName == "3_4")
    {
      PlayerPrefs.SetString("3_4", "clear");
      PlayerPrefs.Save();
    }
    if(stageName == "3_5")
    {
      PlayerPrefs.SetString("3_5", "clear");
      PlayerPrefs.Save();
    }
    if(stageName == "3_boss")
    {
      PlayerPrefs.SetString("3_boss", "clear");
      PlayerPrefs.Save();
    }
    if(stageName == "4_1")
    {
      PlayerPrefs.SetString("4_1", "clear");
      PlayerPrefs.Save();
    }
    if(stageName == "4_2")
    {
      PlayerPrefs.SetString("4_2", "clear");
      PlayerPrefs.Save();
    }
    if(stageName == "4_3")
    {
      PlayerPrefs.SetString("4_3", "clear");
      PlayerPrefs.Save();
    }
    if(stageName == "4_4")
    {
      PlayerPrefs.SetString("4_4", "clear");
      PlayerPrefs.Save();
    }
    if(stageName == "4_5")
    {
      PlayerPrefs.SetString("4_5", "clear");
      PlayerPrefs.Save();
    }
    if(stageName == "4_boss")
    {
      PlayerPrefs.SetString("4_boss", "clear");
      PlayerPrefs.Save();
    }

  }

  public void Lose()
  {
    isDefeat = true;
    unablePanel.SetActive(true);
    pausePanel.SetActive(false);
    ResultText.text = "You lose...";
    ReplayText.text = "Tap screen to end this game";

    PlayerPrefs.SetInt("loseNumber", PlayerPrefs.GetInt("loseNumber", 0) + 1);
    PlayerPrefs.Save();

  }

  public void Draw()
  {
    ResultText.text = "Draw Game";
  }
}
