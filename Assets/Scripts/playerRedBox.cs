using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
//CameraのProjectionはOrthographicに。

public class playerRedBox : MonoBehaviour,IDragHandler
{
  private GameControllerScript gameController;
  private playerWhiteBox playerWhiteBox;
  private playerBlueBox playerBlueBox;
  public GameObject particleObjectChangePosition;
  public AudioClip changePositionSE;
  public GameObject playerOF2;
  public int playerOF2Attack;
  public int playerOF2Interval;
  public int playerOF2SpawnTime;
  public string playerOF2Element;
  public GameObject particleObject1;

  public void OnDrag(PointerEventData data){
		Vector3 TargetPos = Camera.main.ScreenToWorldPoint (data.position);
    if (TargetPos.x < -1.5f)
    {

      if (playerWhiteBox.transform.position.x < -1.5f)
      {

        if(transform.position != new Vector3(-2f,-3.5f,1f))
        {
          Instantiate(
              particleObjectChangePosition,
              new Vector3(transform.position.x, transform.position.y, 3f),
              particleObjectChangePosition.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成

        }

        playerWhiteBox.transform.position = transform.position;
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

      if ((playerWhiteBox.transform.position.x >= -1.5f)&&(playerWhiteBox.transform.position.x < -0.5f))
      {

        if(transform.position != new Vector3(-1f,-3.5f,1f))
        {
          Instantiate(
              particleObjectChangePosition,
              new Vector3(transform.position.x, transform.position.y, 3f),
              particleObjectChangePosition.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成

        }

        playerWhiteBox.transform.position = transform.position;
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
      if ((playerWhiteBox.transform.position.x >= -0.5f)&&(playerWhiteBox.transform.position.x < 0.5f))
      {

        if(transform.position != new Vector3(0f,-3.5f,1f))
        {
          Instantiate(
              particleObjectChangePosition,
              new Vector3(transform.position.x, transform.position.y, 3f),
              particleObjectChangePosition.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成

        }

        playerWhiteBox.transform.position = transform.position;
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
      if ((playerWhiteBox.transform.position.x >= 0.5f)&&(playerWhiteBox.transform.position.x < 1.5f))
      {

        if(transform.position != new Vector3(1f,-3.5f,1f))
        {
          Instantiate(
              particleObjectChangePosition,
              new Vector3(transform.position.x, transform.position.y, 3f),
              particleObjectChangePosition.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成

        }

        playerWhiteBox.transform.position = transform.position;
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
      if (playerWhiteBox.transform.position.x >= 1.5f)
      {

        if(transform.position != new Vector3(2f,-3.5f,1f))
        {
          Instantiate(
              particleObjectChangePosition,
              new Vector3(transform.position.x, transform.position.y, 3f),
              particleObjectChangePosition.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成

        }

        playerWhiteBox.transform.position = transform.position;
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

  IEnumerator SpawnPlayerOF2()
  {
      while (true)
      {
          Instantiate(
              playerOF2,
              new Vector3(transform.position.x, transform.position.y, 0f),
              transform.rotation
          );
          Instantiate(
              particleObject1,
              new Vector3(transform.position.x, transform.position.y, -3f),
              particleObject1.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成
          yield return new WaitForSeconds(playerOF2SpawnTime);
      }

  }

    // Start is called before the first frame update
    void Start()
    {
      transform.position = new Vector3(0f,-3.5f,1f);
      StartCoroutine("SpawnPlayerOF2");
      gameController = GameObject
          .FindWithTag("GameController")
          .GetComponent<GameControllerScript>();
      playerWhiteBox = GameObject
                  .FindWithTag("playerBox3")
                  .GetComponent<playerWhiteBox>();
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
