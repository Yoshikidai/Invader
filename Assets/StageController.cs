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

    }

    // Update is called once per frame
    void Update()
    {

    }
}
