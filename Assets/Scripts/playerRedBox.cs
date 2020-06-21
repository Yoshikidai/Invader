using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
//CameraのProjectionはOrthographicに。

public class playerRedBox : MonoBehaviour,IDragHandler
{

  private playerBlueBox playerBlueBox;
  private playerWhiteBox playerWhiteBox;

  public void OnDrag(PointerEventData data){
		Vector3 TargetPos = Camera.main.ScreenToWorldPoint (data.position);
    if (TargetPos.x < -1.5f)
    {

      if (playerBlueBox.transform.position.x < -1.5f)
      {
        playerBlueBox.transform.position = transform.position;
      }
      else if (playerWhiteBox.transform.position.x < -1.5f)
      {
        playerWhiteBox.transform.position = transform.position;
      }

      transform.position = new Vector3(-2f,-3.5f,0f);

    }
    else if (TargetPos.x < -0.5f)
    {

      if ((playerBlueBox.transform.position.x >= -1.5f)&&(playerBlueBox.transform.position.x < -0.5f))
      {
        playerBlueBox.transform.position = transform.position;
      }
      else if ((playerWhiteBox.transform.position.x >= -1.5f)&&(playerWhiteBox.transform.position.x < -0.5f))
      {
        playerWhiteBox.transform.position = transform.position;
      }

      transform.position = new Vector3(-1f,-3.5f,0f);
    }
    else if (TargetPos.x < 0.5f)
    {
      if ((playerBlueBox.transform.position.x >= -0.5f)&&(playerBlueBox.transform.position.x < 0.5f))
      {
        playerBlueBox.transform.position = transform.position;
      }
      else if ((playerWhiteBox.transform.position.x >= -0.5f)&&(playerWhiteBox.transform.position.x < 0.5f))
      {
        playerWhiteBox.transform.position = transform.position;
      }

      transform.position = new Vector3(0f,-3.5f,0f);
    }
    else if (TargetPos.x < 1.5f)
    {
      if ((playerBlueBox.transform.position.x >= 0.5f)&&(playerBlueBox.transform.position.x < 1.5f))
      {
        playerBlueBox.transform.position = transform.position;
      }
      else if ((playerWhiteBox.transform.position.x >= 0.5f)&&(playerWhiteBox.transform.position.x < 1.5f))
      {
        playerWhiteBox.transform.position = transform.position;
      }

      transform.position = new Vector3(1f,-3.5f,0f);
    }
    else
    {
      if (playerBlueBox.transform.position.x >= 1.5f)
      {
        playerBlueBox.transform.position = transform.position;
      }
      else if (playerWhiteBox.transform.position.x >= 1.5f)
      {
        playerWhiteBox.transform.position = transform.position;
      }
      transform.position = new Vector3(2f,-3.5f,0f);
    }
	}

    // Start is called before the first frame update
    void Start()
    {
      transform.position = new Vector3(0f,-3.5f,0f);
      playerBlueBox = GameObject
                  .FindWithTag("playerBox1")
                  .GetComponent<playerBlueBox>();
      playerWhiteBox = GameObject
                  .FindWithTag("playerBox3")
                  .GetComponent<playerWhiteBox>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
