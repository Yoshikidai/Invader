using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
//CameraのProjectionはOrthographicに。

public class playerWhiteBox : MonoBehaviour,IDragHandler
{
  private GameControllerScript gameController;
  private playerRedBox playerRedBox;
  private playerBlueBox playerBlueBox;
  public GameObject particleObjectChangePosition;
  public AudioClip changePositionSE;
  public GameObject playerOF3;
  public int playerOF3Attack;
  public int playerOF3Interval;
  public int playerOF3SpawnTime;
  public string playerOF3Element;
  public GameObject particleObject1;

  public void OnDrag(PointerEventData data){
		Vector3 TargetPos = Camera.main.ScreenToWorldPoint (data.position);
    if (TargetPos.x < -1.5f)
    {

      if (playerRedBox.transform.position.x < -1.5f)
      {

        if(transform.position != new Vector3(-2f,-3.5f,1f))
        {
          Instantiate(
              particleObjectChangePosition,
              new Vector3(transform.position.x, transform.position.y, 3f),
              particleObjectChangePosition.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成

        }

        playerRedBox.transform.position = transform.position;
      }
      else if (playerBlueBox.transform.position.x < -1.5f)
      {

        if(transform.position != new Vector3(-2f,-3.5f,1f))
        {
          Instantiate(
              particleObjectChangePosition,
              new Vector3(transform.position.x, transform.position.y, 3f),
              particleObjectChangePosition.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成

        }

        playerBlueBox.transform.position = transform.position;
      }

      if(transform.position != new Vector3(-2f,-3.5f,1f))
      {
        Instantiate(
            particleObjectChangePosition,
            new Vector3(-2f,-3.5f, 3f),
            particleObjectChangePosition.transform.rotation
        ); //パーティクル用ゲームオブジェクト生成

        // オーディオを再生
        AudioSource.PlayClipAtPoint(changePositionSE, transform.position);
      }

      transform.position = new Vector3(-2f,-3.5f,1f);

    }
    else if (TargetPos.x < -0.5f)
    {

      if ((playerRedBox.transform.position.x >= -1.5f)&&(playerRedBox.transform.position.x < -0.5f))
      {

        if(transform.position != new Vector3(-1f,-3.5f,1f))
        {
          Instantiate(
              particleObjectChangePosition,
              new Vector3(transform.position.x, transform.position.y, 3f),
              particleObjectChangePosition.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成

        }

        playerRedBox.transform.position = transform.position;
      }
      else if ((playerBlueBox.transform.position.x >= -1.5f)&&(playerBlueBox.transform.position.x < -0.5f))
      {

        if(transform.position != new Vector3(-1f,-3.5f,1f))
        {
          Instantiate(
              particleObjectChangePosition,
              new Vector3(transform.position.x, transform.position.y, 3f),
              particleObjectChangePosition.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成

        }

        playerBlueBox.transform.position = transform.position;
      }

      if(transform.position != new Vector3(-1f,-3.5f,1f))
      {
        Instantiate(
            particleObjectChangePosition,
            new Vector3(-1f,-3.5f, 3f),
            particleObjectChangePosition.transform.rotation
        ); //パーティクル用ゲームオブジェクト生成

        // オーディオを再生
        AudioSource.PlayClipAtPoint(changePositionSE, transform.position);
      }

      transform.position = new Vector3(-1f,-3.5f,1f);
    }
    else if (TargetPos.x < 0.5f)
    {
      if ((playerRedBox.transform.position.x >= -0.5f)&&(playerRedBox.transform.position.x < 0.5f))
      {

        if(transform.position != new Vector3(0f,-3.5f,1f))
        {
          Instantiate(
              particleObjectChangePosition,
              new Vector3(transform.position.x, transform.position.y, 3f),
              particleObjectChangePosition.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成

        }

        playerRedBox.transform.position = transform.position;
      }
      else if ((playerBlueBox.transform.position.x >= -0.5f)&&(playerBlueBox.transform.position.x < 0.5f))
      {

        if(transform.position != new Vector3(0f,-3.5f,1f))
        {
          Instantiate(
              particleObjectChangePosition,
              new Vector3(transform.position.x, transform.position.y, 3f),
              particleObjectChangePosition.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成

        }

        playerBlueBox.transform.position = transform.position;
      }

      if(transform.position != new Vector3(0f,-3.5f,1f))
      {
        Instantiate(
            particleObjectChangePosition,
            new Vector3(0f,-3.5f, 3f),
            particleObjectChangePosition.transform.rotation
        ); //パーティクル用ゲームオブジェクト生成

        // オーディオを再生
        AudioSource.PlayClipAtPoint(changePositionSE, transform.position);
      }

      transform.position = new Vector3(0f,-3.5f,1f);
    }
    else if (TargetPos.x < 1.5f)
    {
      if ((playerRedBox.transform.position.x >= 0.5f)&&(playerRedBox.transform.position.x < 1.5f))
      {

        if(transform.position != new Vector3(1f,-3.5f,1f))
        {
          Instantiate(
              particleObjectChangePosition,
              new Vector3(transform.position.x, transform.position.y, 3f),
              particleObjectChangePosition.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成

        }

        playerRedBox.transform.position = transform.position;
      }
      else if ((playerBlueBox.transform.position.x >= 0.5f)&&(playerBlueBox.transform.position.x < 1.5f))
      {

        if(transform.position != new Vector3(1f,-3.5f,1f))
        {
          Instantiate(
              particleObjectChangePosition,
              new Vector3(transform.position.x, transform.position.y, 3f),
              particleObjectChangePosition.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成

        }

        playerBlueBox.transform.position = transform.position;
      }

      if(transform.position != new Vector3(1f,-3.5f,1f))
      {
        Instantiate(
            particleObjectChangePosition,
            new Vector3(1f,-3.5f, 3f),
            particleObjectChangePosition.transform.rotation
        ); //パーティクル用ゲームオブジェクト生成

        // オーディオを再生
        AudioSource.PlayClipAtPoint(changePositionSE, transform.position);
      }

      transform.position = new Vector3(1f,-3.5f,1f);
    }
    else
    {
      if (playerRedBox.transform.position.x >= 1.5f)
      {

        if(transform.position != new Vector3(2f,-3.5f,1f))
        {
          Instantiate(
              particleObjectChangePosition,
              new Vector3(transform.position.x, transform.position.y, 3f),
              particleObjectChangePosition.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成

        }

        playerRedBox.transform.position = transform.position;
      }
      else if (playerBlueBox.transform.position.x >= 1.5f)
      {

        if(transform.position != new Vector3(2f,-3.5f,1f))
        {
          Instantiate(
              particleObjectChangePosition,
              new Vector3(transform.position.x, transform.position.y, 3f),
              particleObjectChangePosition.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成

        }

        playerBlueBox.transform.position = transform.position;
      }

      if(transform.position != new Vector3(2f,-3.5f,1f))
      {
        Instantiate(
            particleObjectChangePosition,
            new Vector3(2f,-3.5f, 3f),
            particleObjectChangePosition.transform.rotation
        ); //パーティクル用ゲームオブジェクト生成

        // オーディオを再生
        AudioSource.PlayClipAtPoint(changePositionSE, transform.position);
      }

      transform.position = new Vector3(2f,-3.5f,1f);
    }
	}

  IEnumerator SpawnPlayerOF3()
  {
      while (true)
      {
          Instantiate(
              playerOF3,
              new Vector3(transform.position.x, transform.position.y, 0f),
              transform.rotation
          );
          Instantiate(
              particleObject1,
              new Vector3(transform.position.x, transform.position.y, -3f),
              particleObject1.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成
          yield return new WaitForSeconds(playerOF3SpawnTime);
      }

  }


    // Start is called before the first frame update
    void Start()
    {
      transform.position = new Vector3(2f,-3.5f,1f);
      StartCoroutine("SpawnPlayerOF3");
      gameController = GameObject
          .FindWithTag("GameController")
          .GetComponent<GameControllerScript>();
      playerRedBox = GameObject
                  .FindWithTag("playerBox2")
                  .GetComponent<playerRedBox>();
      playerBlueBox = GameObject
                  .FindWithTag("playerBox1")
                  .GetComponent<playerBlueBox>();
    }

    // Update is called once per frame
    void Update()
    {
      if(gameController.isDefeat)
      {
        StopCoroutine("SpawnPlayerOF2");
      }

    }
}
