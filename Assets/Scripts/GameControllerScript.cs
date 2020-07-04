using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour
{
  public GameObject playerOF1;
  public int playerOF1Attack;
  public int playerOF1Interval;
  public int playerOF1SpawnTime;
  public string playerOF1Element;
  public GameObject playerOF2;
  public int playerOF2Attack;
  public int playerOF2Interval;
  public int playerOF2SpawnTime;
  public string playerOF2Element;
  public GameObject playerOF3;
  public int playerOF3Attack;
  public int playerOF3Interval;
  public int playerOF3SpawnTime;
  public string playerOF3Element;

  public GameObject particleObject1;

  public GameObject playerOFbox1;
  public GameObject playerOFbox2;
  public GameObject playerOFbox3;
  public GameObject playerOFbox4;

  public GameObject playerDF1;
  public int playerDF1Attack;
  public int playerDF1Interval;
  public string playerDF1Element;
  public GameObject playerDF2;
  public int playerDF2Attack;
  public int playerDF2Interval;
  public string playerDF2Element;
  public GameObject playerDF3;
  public int playerDF3Attack;
  public int playerDF3Interval;
  public string playerDF3Element;
  public GameObject playerDF4;
  public int playerDF4Attack;
  public int playerDF4Interval;
  public string playerDF4Element;
  public GameObject playerDF5;
  public int playerDF5Attack;
  public int playerDF5Interval;
  public string playerDF5Element;
  public GameObject playerDF6;
  public int playerDF6Attack;
  public int playerDF6Interval;
  public string playerDF6Element;

  public GameObject enemyOF1;
  public int enemyOF1Attack;
  public int enemyOF1Interval;
  public int enemyOF1SpawnTime;
  public string enemyOF1Element;
  public GameObject enemyOF2;
  public int enemyOF2Attack;
  public int enemyOF2Interval;
  public int enemyOF2SpawnTime;
  public string enemyOF2Element;
  public GameObject enemyOF3;
  public int enemyOF3Attack;
  public int enemyOF3Interval;
  public int enemyOF3SpawnTime;
  public string enemyOF3Element;

  public GameObject particleObject2;

  public GameObject enemyOFbox1;
  public GameObject enemyOFbox2;
  public GameObject enemyOFbox3;
  public GameObject enemyOFbox4;

  public GameObject enemyDF1;
  public int enemyDF1Attack;
  public int enemyDF1Interval;
  public string enemyDF1Element;
  public GameObject enemyDF2;
  public int enemyDF2Attack;
  public int enemyDF2Interval;
  public string enemyDF2Element;
  public GameObject enemyDF3;
  public int enemyDF3Attack;
  public int enemyDF3Interval;
  public string enemyDF3Element;
  public GameObject enemyDF4;
  public int enemyDF4Attack;
  public int enemyDF4Interval;
  public string enemyDF4Element;
  public GameObject enemyDF5;
  public int enemyDF5Attack;
  public int enemyDF5Interval;
  public string enemyDF5Element;
  public GameObject enemyDF6;
  public int enemyDF6Attack;
  public int enemyDF6Interval;
  public string enemyDF6Element;

  public GameObject emptyOFbox1;
  public GameObject emptyOFbox2;
  public GameObject emptyOFbox3;
  public GameObject emptyOFbox4;
  public GameObject emptyOFbox5;
  public GameObject emptyOFbox6;
  public GameObject emptyOFbox7;
  public GameObject emptyOFbox8;
  public GameObject emptyOFbox9;
  public GameObject emptyOFbox10;

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

  // Start is called before the first frame update
  void Start()
  {
    playerBoxNumber = Random.Range(1, 5);
    enemyBoxNumber = Random.Range(1, 5);

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

    if(enemyBoxNumber == 1)
    {
      Instantiate(
          enemyOFbox2,
          new Vector3(-2f,-transform.position.y,1f),
          transform.rotation
      );
      Instantiate(
          enemyOFbox3,
          new Vector3(0f,-transform.position.y,1f),
          transform.rotation
      );
      Instantiate(
          enemyOFbox4,
          new Vector3(2f,-transform.position.y,1f),
          transform.rotation
      );

    }
    else if(enemyBoxNumber == 2)
    {
      Instantiate(
          enemyOFbox1,
          new Vector3(-2f,-transform.position.y,1f),
          transform.rotation
      );
      Instantiate(
          enemyOFbox3,
          new Vector3(0f,-transform.position.y,1f),
          transform.rotation
      );
      Instantiate(
          enemyOFbox4,
          new Vector3(2f,-transform.position.y,1f),
          transform.rotation
      );

    }
    else if(enemyBoxNumber == 3)
    {
      Instantiate(
          enemyOFbox1,
          new Vector3(-2f,-transform.position.y,1f),
          transform.rotation
      );
      Instantiate(
          enemyOFbox2,
          new Vector3(0f,-transform.position.y,1f),
          transform.rotation
      );
      Instantiate(
          enemyOFbox4,
          new Vector3(2f,-transform.position.y,1f),
          transform.rotation
      );

    }
    else if(enemyBoxNumber == 4)
    {
      Instantiate(
          enemyOFbox1,
          new Vector3(-2f,-transform.position.y,1f),
          transform.rotation
      );
      Instantiate(
          enemyOFbox2,
          new Vector3(0f,-transform.position.y,1f),
          transform.rotation
      );
      Instantiate(
          enemyOFbox3,
          new Vector3(2f,-transform.position.y,1f),
          transform.rotation
      );

    }


    Instantiate(
        emptyOFbox1,
        new Vector3(-2f,transform.position.y,2f),
        transform.rotation
    );
    Instantiate(
        emptyOFbox2,
        new Vector3(-1f,transform.position.y,2f),
        transform.rotation
    );
    Instantiate(
        emptyOFbox3,
        new Vector3(0f,transform.position.y,2f),
        transform.rotation
    );
    Instantiate(
        emptyOFbox4,
        new Vector3(1f,transform.position.y,2f),
        transform.rotation
    );
    Instantiate(
        emptyOFbox5,
        new Vector3(2f,transform.position.y,2f),
        transform.rotation
    );
    Instantiate(
        emptyOFbox6,
        new Vector3(-2f,-transform.position.y,2f),
        transform.rotation
    );
    Instantiate(
        emptyOFbox7,
        new Vector3(-1f,-transform.position.y,2f),
        transform.rotation
    );
    Instantiate(
        emptyOFbox8,
        new Vector3(0f,-transform.position.y,2f),
        transform.rotation
    );
    Instantiate(
        emptyOFbox9,
        new Vector3(1f,-transform.position.y,2f),
        transform.rotation
    );
    Instantiate(
        emptyOFbox10,
        new Vector3(2f,-transform.position.y,2f),
        transform.rotation
    );

    ResultText.text = "";
    ReplayText.text = "";
    isVictory = false;
    isDefeat = false;

    DF1 = GameObject.FindGameObjectsWithTag("playerDF1");
    DF2 = GameObject.FindGameObjectsWithTag("playerDF2");
    DF3 = GameObject.FindGameObjectsWithTag("playerDF3");
    DF4 = GameObject.FindGameObjectsWithTag("playerDF4");
    DF5 = GameObject.FindGameObjectsWithTag("playerDF5");
    DF6 = GameObject.FindGameObjectsWithTag("playerDF6");

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

      SceneManager.LoadScene("STAGE1");
    }

  }

  public void Win()
  {
    isVictory = true;
    ResultText.text = "You win!";
    ReplayText.text = "Tap screen to end this game";
  }

  public void Lose()
  {
    isDefeat = true;
    ResultText.text = "You lose...";
    ReplayText.text = "Tap screen to end this game";
  }

  public void Draw()
  {
    ResultText.text = "Draw Game";
  }
}
