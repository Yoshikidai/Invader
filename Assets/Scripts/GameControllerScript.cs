﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour
{
  public GameObject particleObject1;

  public GameObject playerOFbox1;
  public GameObject playerOFbox2;
  public GameObject playerOFbox3;
  public GameObject playerOFbox4;

  public GameObject particleObject2;

  public GameObject enemyOFbox1;
  public GameObject enemyOFbox2;
  public GameObject enemyOFbox3;
  public GameObject enemyOFbox4;

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

  // Start is called before the first frame update
  void Start()
  {
    stageName = SceneController.getStage();

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

    ResultText.text = "";
    ReplayText.text = "";
    isVictory = false;
    isDefeat = false;

    emptyOFbox = GameObject.FindGameObjectsWithTag("emptyBox");

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
