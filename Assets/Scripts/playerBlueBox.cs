using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
//CameraのProjectionはOrthographicに。

public class playerBlueBox : MonoBehaviour,IDragHandler
{

  private playerRedBox playerRedBox;
  private playerWhiteBox playerWhiteBox;
  public GameObject particleObjectChangePosition;
  public AudioClip changePositionSE;

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

          // オーディオを再生
          AudioSource.PlayClipAtPoint(changePositionSE, transform.position);
        }

        playerRedBox.transform.position = transform.position;

      }
      else if (playerWhiteBox.transform.position.x < -1.5f)
      {

        if(transform.position != new Vector3(-2f,-3.5f,1f))
        {
          Instantiate(
              particleObjectChangePosition,
              new Vector3(transform.position.x, transform.position.y, 3f),
              particleObjectChangePosition.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成

          // オーディオを再生
          AudioSource.PlayClipAtPoint(changePositionSE, transform.position);
        }

        playerWhiteBox.transform.position = transform.position;

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

          // オーディオを再生
          AudioSource.PlayClipAtPoint(changePositionSE, transform.position);
        }

        playerRedBox.transform.position = transform.position;

      }
      else if ((playerWhiteBox.transform.position.x >= -1.5f)&&(playerWhiteBox.transform.position.x < -0.5f))
      {

        if(transform.position != new Vector3(-1f,-3.5f,1f))
        {
          Instantiate(
              particleObjectChangePosition,
              new Vector3(transform.position.x, transform.position.y, 3f),
              particleObjectChangePosition.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成

          // オーディオを再生
          AudioSource.PlayClipAtPoint(changePositionSE, transform.position);
        }

        playerWhiteBox.transform.position = transform.position;

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

          // オーディオを再生
          AudioSource.PlayClipAtPoint(changePositionSE, transform.position);
        }

        playerRedBox.transform.position = transform.position;

      }
      else if ((playerWhiteBox.transform.position.x >= -0.5f)&&(playerWhiteBox.transform.position.x < 0.5f))
      {

        if(transform.position != new Vector3(0f,-3.5f,1f))
        {
          Instantiate(
              particleObjectChangePosition,
              new Vector3(transform.position.x, transform.position.y, 3f),
              particleObjectChangePosition.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成

          // オーディオを再生
          AudioSource.PlayClipAtPoint(changePositionSE, transform.position);
        }

        playerWhiteBox.transform.position = transform.position;

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

          // オーディオを再生
          AudioSource.PlayClipAtPoint(changePositionSE, transform.position);
        }

        playerRedBox.transform.position = transform.position;

      }
      else if ((playerWhiteBox.transform.position.x >= 0.5f)&&(playerWhiteBox.transform.position.x < 1.5f))
      {

        if(transform.position != new Vector3(1f,-3.5f,1f))
        {
          Instantiate(
              particleObjectChangePosition,
              new Vector3(transform.position.x, transform.position.y, 3f),
              particleObjectChangePosition.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成

          // オーディオを再生
          AudioSource.PlayClipAtPoint(changePositionSE, transform.position);
        }

        playerWhiteBox.transform.position = transform.position;

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

          // オーディオを再生
          AudioSource.PlayClipAtPoint(changePositionSE, transform.position);
        }

        playerRedBox.transform.position = transform.position;

      }
      else if (playerWhiteBox.transform.position.x >= 1.5f)
      {

        if(transform.position != new Vector3(2f,-3.5f,1f))
        {
          Instantiate(
              particleObjectChangePosition,
              new Vector3(transform.position.x, transform.position.y, 3f),
              particleObjectChangePosition.transform.rotation
          ); //パーティクル用ゲームオブジェクト生成

          // オーディオを再生
          AudioSource.PlayClipAtPoint(changePositionSE, transform.position);
        }

        playerWhiteBox.transform.position = transform.position;

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

    // Start is called before the first frame update
    void Start()
    {
      transform.position = new Vector3(-2f,-3.5f,1f);
      playerRedBox = GameObject
                  .FindWithTag("playerBox2")
                  .GetComponent<playerRedBox>();
      playerWhiteBox = GameObject
                  .FindWithTag("playerBox3")
                  .GetComponent<playerWhiteBox>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
