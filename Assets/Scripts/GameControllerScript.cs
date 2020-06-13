﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour
{

  public GameObject playerOF1;
  public GameObject playerOF2;
  public GameObject playerOF3;
  public GameObject enemyOF1;
  public GameObject enemyOF2;
  public GameObject enemyOF3;
  public Text ReplayText;
  public Text ResultText;
  private bool isGameOver;

  IEnumerator SpawnPlayerOF1()
  {
      while (true)
      {
          Instantiate(
              playerOF1,
              new Vector3(Random.Range(-2, 3), transform.position.y, 0f),
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
              new Vector3(Random.Range(-2, 3), transform.position.y, 0f),
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
              new Vector3(Random.Range(-2, 3), transform.position.y, 0f),
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
              new Vector3(Random.Range(-2, 3), -transform.position.y, 0f),
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
              new Vector3(Random.Range(-2, 3), -transform.position.y, 0f),
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
              new Vector3(Random.Range(-2, 3), -transform.position.y, 0f),
              transform.rotation
          );
          yield return new WaitForSeconds(6f);
      }
  }



    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine("SpawnPlayerOF1");
      StartCoroutine("SpawnPlayerOF2");
      StartCoroutine("SpawnPlayerOF3");
      ResultText.text = "";
      ReplayText.text = "";
      isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
      if (!isGameOver)
      {
        return;
      }

      if (Input.GetMouseButtonDown(0))
      {
        SceneManager.LoadScene("MainScene");
      }
    }

    public void Win()
    {
      isGameOver = true;
      ResultText.text = "You win!";
      ReplayText.text = "Tap screen to play again";
    }

    public void Lose()
    {
      isGameOver = true;
      ResultText.text = "You lose!";
      ReplayText.text = "Tap screen to play again";
    }
}
