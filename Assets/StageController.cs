using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour
{
  private stage1_1 stage1_1;
  private stage1_2 stage1_2;
  private stage1_3 stage1_3;
  private stage1_4 stage1_4;
  private stage1_5 stage1_5;
  private stage1_boss stage1_boss;
  private stage2_1 stage2_1;
  private stage2_2 stage2_2;
  private stage2_3 stage2_3;
  private stage2_4 stage2_4;
  private stage2_5 stage2_5;
  private stage2_boss stage2_boss;
  private stage3_1 stage3_1;
  private stage3_2 stage3_2;
  private stage3_3 stage3_3;
  private stage3_4 stage3_4;
  private stage3_5 stage3_5;
  private stage3_boss stage3_boss;
  private stage4_1 stage4_1;
  private stage4_2 stage4_2;
  private stage4_3 stage4_3;
  private stage4_4 stage4_4;
  private stage4_5 stage4_5;
  private stage4_boss stage4_boss;

  private string stageName;

    // Start is called before the first frame update
    void Start()
    {
      stage1_1 = GameObject.FindWithTag("GameController").GetComponent<stage1_1>();
      stage1_2 = GameObject.FindWithTag("GameController").GetComponent<stage1_2>();
      stage1_3 = GameObject.FindWithTag("GameController").GetComponent<stage1_3>();
      stage1_4 = GameObject.FindWithTag("GameController").GetComponent<stage1_4>();
      stage1_5 = GameObject.FindWithTag("GameController").GetComponent<stage1_5>();

      stage1_boss = GameObject.FindWithTag("GameController").GetComponent<stage1_boss>();
      stage2_1 = GameObject.FindWithTag("GameController").GetComponent<stage2_1>();
      stage2_2 = GameObject.FindWithTag("GameController").GetComponent<stage2_2>();
      stage2_3 = GameObject.FindWithTag("GameController").GetComponent<stage2_3>();
      stage2_4 = GameObject.FindWithTag("GameController").GetComponent<stage2_4>();
      stage2_5 = GameObject.FindWithTag("GameController").GetComponent<stage2_5>();
      stage2_boss = GameObject.FindWithTag("GameController").GetComponent<stage2_boss>();

      stage3_1 = GameObject.FindWithTag("GameController").GetComponent<stage3_1>();
      stage3_2 = GameObject.FindWithTag("GameController").GetComponent<stage3_2>();
      stage3_3 = GameObject.FindWithTag("GameController").GetComponent<stage3_3>();
      stage3_4 = GameObject.FindWithTag("GameController").GetComponent<stage3_4>();
      stage3_5 = GameObject.FindWithTag("GameController").GetComponent<stage3_5>();
      stage3_boss = GameObject.FindWithTag("GameController").GetComponent<stage3_boss>();

      stage4_1 = GameObject.FindWithTag("GameController").GetComponent<stage4_1>();
      stage4_2 = GameObject.FindWithTag("GameController").GetComponent<stage4_2>();
      stage4_3 = GameObject.FindWithTag("GameController").GetComponent<stage4_3>();
      stage4_4 = GameObject.FindWithTag("GameController").GetComponent<stage4_4>();
      stage4_5 = GameObject.FindWithTag("GameController").GetComponent<stage4_5>();
      stage4_boss = GameObject.FindWithTag("GameController").GetComponent<stage4_boss>();

      stageName = SceneController.getStage();

      if(stageName == "1_1")
      {
        stage1_1.enabled = true;
      }
      else if(stageName == "1_2")
      {
        stage1_2.enabled = true;
      }
      else if(stageName == "1_3")
      {
        stage1_3.enabled = true;
      }
      else if(stageName == "1_4")
      {
        stage1_4.enabled = true;
      }
      else if(stageName == "1_5")
      {
        stage1_5.enabled = true;
      }
      else if(stageName == "1_boss")
      {
        stage1_boss.enabled = true;
      }

      if(stageName == "2_1")
      {
        stage2_1.enabled = true;
      }
      else if(stageName == "2_2")
      {
        stage2_2.enabled = true;
      }
      else if(stageName == "2_3")
      {
        stage2_3.enabled = true;
      }
      else if(stageName == "2_4")
      {
        stage2_4.enabled = true;
      }
      else if(stageName == "2_5")
      {
        stage2_5.enabled = true;
      }
      else if(stageName == "2_boss")
      {
        stage2_boss.enabled = true;
      }

      if(stageName == "3_1")
      {
        stage3_1.enabled = true;
      }
      else if(stageName == "3_2")
      {
        stage3_2.enabled = true;
      }
      else if(stageName == "3_3")
      {
        stage3_3.enabled = true;
      }
      else if(stageName == "3_4")
      {
        stage3_4.enabled = true;
      }
      else if(stageName == "3_5")
      {
        stage3_5.enabled = true;
      }
      else if(stageName == "3_boss")
      {
        stage3_boss.enabled = true;
      }

      if(stageName == "4_1")
      {
        stage4_1.enabled = true;
      }
      else if(stageName == "4_2")
      {
        stage4_2.enabled = true;
      }
      else if(stageName == "4_3")
      {
        stage4_3.enabled = true;
      }
      else if(stageName == "4_4")
      {
        stage4_4.enabled = true;
      }
      else if(stageName == "4_5")
      {
        stage4_5.enabled = true;
      }
      else if(stageName == "4_boss")
      {
        stage4_boss.enabled = true;
      }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
