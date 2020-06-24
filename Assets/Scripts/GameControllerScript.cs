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

  // Start is called before the first frame update
  void Start()
  {
    playerOFbox1.transform.position = new Vector3
    (
      -2f,
      transform.position.y,
      1f
    );
    playerOFbox2.transform.position = new Vector3
    (
      0f,
      transform.position.y,
      1f
    );
    playerOFbox3.transform.position = new Vector3
    (
      2f,
      transform.position.y,
      1f
    );
    enemyOFbox1.transform.position = new Vector3
    (
      -2f,
      -transform.position.y,
      1f
    );
    enemyOFbox2.transform.position = new Vector3
    (
      0f,
      -transform.position.y,
      1f
    );
    enemyOFbox3.transform.position = new Vector3
    (
      2f,
      -transform.position.y,
      1f
    );
    emptyOFbox1.transform.position = new Vector3
    (
      -2f,
      transform.position.y,
      2f
    );
    emptyOFbox2.transform.position = new Vector3
    (
      -1f,
      transform.position.y,
      2f
    );
    emptyOFbox3.transform.position = new Vector3
    (
      0f,
      transform.position.y,
      2f
    );
    emptyOFbox4.transform.position = new Vector3
    (
      1f,
      transform.position.y,
      2f
    );
    emptyOFbox5.transform.position = new Vector3
    (
      2f,
      transform.position.y,
      2f
    );
    emptyOFbox6.transform.position = new Vector3
    (
      -2f,
      -transform.position.y,
      2f
    );
    emptyOFbox7.transform.position = new Vector3
    (
      -1f,
      -transform.position.y,
      2f
    );
    emptyOFbox8.transform.position = new Vector3
    (
      0f,
      -transform.position.y,
      2f
    );
    emptyOFbox9.transform.position = new Vector3
    (
      1f,
      -transform.position.y,
      2f
    );
    emptyOFbox10.transform.position = new Vector3
    (
      2f,
      -transform.position.y,
      2f
    );

    StartCoroutine("SpawnPlayerOF1");
    StartCoroutine("SpawnPlayerOF2");
    StartCoroutine("SpawnPlayerOF3");
    StartCoroutine("SpawnEnemyOF1");
    StartCoroutine("SpawnEnemyOF2");
    StartCoroutine("SpawnEnemyOF3");
    ResultText.text = "";
    ReplayText.text = "";
    isVictory = false;
    isDefeat = false;
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
      SceneManager.LoadScene("ModeSelectScene");
    }

  }

  public void Win()
  {
    isVictory = true;
    ResultText.text = "You win!";
    ReplayText.text = "Tap screen to play again";
    StopCoroutine("SpawnEnemyOF1");
    StopCoroutine("SpawnEnemyOF2");
    StopCoroutine("SpawnEnemyOF3");
  }

  public void Lose()
  {
    isDefeat = true;
    ResultText.text = "You lose...";
    ReplayText.text = "Tap screen to play again";
    StopCoroutine("SpawnPlayerOF1");
    StopCoroutine("SpawnPlayerOF2");
    StopCoroutine("SpawnPlayerOF3");
  }

  public void Draw()
  {
    ResultText.text = "Draw Game";
  }

  IEnumerator SpawnPlayerOF1()
  {
      while (true)
      {
          Instantiate(
              playerOF1,
              new Vector3(playerOFbox1.transform.position.x, transform.position.y, 0f),
              transform.rotation
          );
          Instantiate(
              particleObject1,
              new Vector3(playerOFbox1.transform.position.x, transform.position.y, -3f),
              particleObject1.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成
          yield return new WaitForSeconds(playerOF1SpawnTime);
      }

  }


  IEnumerator SpawnPlayerOF2()
  {
      while (true)
      {
          Instantiate(
              playerOF2,
              new Vector3(playerOFbox2.transform.position.x, transform.position.y, 0f),
              transform.rotation
          );
          Instantiate(
              particleObject1,
              new Vector3(playerOFbox2.transform.position.x, transform.position.y, -3f),
              particleObject1.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成
          yield return new WaitForSeconds(playerOF2SpawnTime);
      }

  }

  IEnumerator SpawnPlayerOF3()
  {
      while (true)
      {
          Instantiate(
              playerOF3,
              new Vector3(playerOFbox3.transform.position.x, transform.position.y, 0f),
              transform.rotation
          );
          Instantiate(
              particleObject1,
              new Vector3(playerOFbox3.transform.position.x, transform.position.y, -3f),
              particleObject1.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成
          yield return new WaitForSeconds(playerOF3SpawnTime);
      }

  }

  IEnumerator SpawnEnemyOF1()
  {
      while (true)
      {
          Instantiate(
              enemyOF1,
              new Vector3(enemyOFbox1.transform.position.x, -transform.position.y, 0f),
              transform.rotation
          );
          Instantiate(
              particleObject2,
              new Vector3(enemyOFbox1.transform.position.x, -transform.position.y, -3f),
              particleObject2.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成

          yield return new WaitForSeconds(enemyOF1SpawnTime);
      }
  }

  IEnumerator SpawnEnemyOF2()
  {
      while (true)
      {
          Instantiate(
              enemyOF2,
              new Vector3(enemyOFbox2.transform.position.x, -transform.position.y, 0f),
              transform.rotation
          );
          Instantiate(
              particleObject2,
              new Vector3(enemyOFbox2.transform.position.x, -transform.position.y, -3f),
              particleObject2.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成
          yield return new WaitForSeconds(enemyOF2SpawnTime);
      }

  }
  IEnumerator SpawnEnemyOF3()
  {
      while (true)
      {
          Instantiate(
              enemyOF3,
              new Vector3(enemyOFbox3.transform.position.x, -transform.position.y, 0f),
              transform.rotation
          );
          Instantiate(
              particleObject2,
              new Vector3(enemyOFbox3.transform.position.x, -transform.position.y, -3f),
              particleObject2.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成
          yield return new WaitForSeconds(enemyOF3SpawnTime);
      }

  }

}
