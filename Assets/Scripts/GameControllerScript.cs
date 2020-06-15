using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour
{

  public GameObject playerOF1;
  public GameObject playerOF2;
  public GameObject playerOF3;
  public GameObject playerOFbox1;
  public GameObject playerOFbox2;
  public GameObject playerOFbox3;
  public GameObject playerDF1;
  public GameObject playerDF2;
  public GameObject playerDF3;
  public GameObject playerDF4;
  public GameObject playerDF5;
  public GameObject playerDF6;
  public GameObject enemyOF1;
  public GameObject enemyOF2;
  public GameObject enemyOF3;
  public GameObject enemyOFbox1;
  public GameObject enemyOFbox2;
  public GameObject enemyOFbox3;
  public GameObject enemyDF1;
  public GameObject enemyDF2;
  public GameObject enemyDF3;
  public GameObject enemyDF4;
  public GameObject enemyDF5;
  public GameObject enemyDF6;
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

    if (Input.GetMouseButtonDown(0))
    {
      SceneManager.LoadScene("Invader");
    }

    if(isVictory)
    {
      isDefeat = false;
    }

    if(isDefeat)
    {
      isVictory = false;
    }

  }

  public void Win()
  {
    isVictory = true;
    ResultText.text = "You win!";
    ReplayText.text = "Tap screen to play again";
  }

  public void Lose()
  {
    isDefeat = true;
    ResultText.text = "You lose!";
    ReplayText.text = "Tap screen to play again";
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
          yield return new WaitForSeconds(6f);
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
          yield return new WaitForSeconds(6f);
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
          yield return new WaitForSeconds(6f);
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
          yield return new WaitForSeconds(6f);
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
          yield return new WaitForSeconds(6f);
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
          yield return new WaitForSeconds(6f);
      }
  }

}
