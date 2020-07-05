using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
  public static string stage;
	// Use this for initialization
	void Start () {
    stage = "";
	}


	// Update is called once per frame
	void Update () {

	}

	public static string getStage(){
		return stage;
	}
}
