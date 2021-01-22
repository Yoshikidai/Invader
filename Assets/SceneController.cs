using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
  public static string stage;
  public static int stageNumber;
  public static int bossStage;

	// Use this for initialization
	void Start () {
    stage = "";
    stageNumber = 1;
    bossStage = 1;
	}


	// Update is called once per frame
	void Update () {

	}

  public static string getStage(){
		return stage;
	}

  public static int getStageNumber(){
		return stageNumber;
	}

  public static int getBossStage(){
		return bossStage;
	}
}
