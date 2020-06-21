using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
//CameraのProjectionはOrthographicに。

public class playerWhiteBox : MonoBehaviour,IDragHandler
{

  private playerRedBox playerRedBox;
  private playerBlueBox playerBlueBox;

  public void OnDrag(PointerEventData data){
		Vector3 TargetPos = Camera.main.ScreenToWorldPoint (data.position);
    if (TargetPos.x < -1.5f)
    {

      if (playerRedBox.transform.position.x < -1.5f)
      {
        playerRedBox.transform.position = transform.position;
      }
      else if (playerBlueBox.transform.position.x < -1.5f)
      {
        playerBlueBox.transform.position = transform.position;
      }

      transform.position = new Vector3(-2f,-3.5f,0f);

    }
    else if (TargetPos.x < -0.5f)
    {

      if ((playerRedBox.transform.position.x >= -1.5f)&&(playerRedBox.transform.position.x < -0.5f))
      {
        playerRedBox.transform.position = transform.position;
      }
      else if ((playerBlueBox.transform.position.x >= -1.5f)&&(playerBlueBox.transform.position.x < -0.5f))
      {
        playerBlueBox.transform.position = transform.position;
      }

      transform.position = new Vector3(-1f,-3.5f,0f);
    }
    else if (TargetPos.x < 0.5f)
    {
      if ((playerRedBox.transform.position.x >= -0.5f)&&(playerRedBox.transform.position.x < 0.5f))
      {
        playerRedBox.transform.position = transform.position;
      }
      else if ((playerBlueBox.transform.position.x >= -0.5f)&&(playerBlueBox.transform.position.x < 0.5f))
      {
        playerBlueBox.transform.position = transform.position;
      }

      transform.position = new Vector3(0f,-3.5f,0f);
    }
    else if (TargetPos.x < 1.5f)
    {
      if ((playerRedBox.transform.position.x >= 0.5f)&&(playerRedBox.transform.position.x < 1.5f))
      {
        playerRedBox.transform.position = transform.position;
      }
      else if ((playerBlueBox.transform.position.x >= 0.5f)&&(playerBlueBox.transform.position.x < 1.5f))
      {
        playerBlueBox.transform.position = transform.position;
      }

      transform.position = new Vector3(1f,-3.5f,0f);
    }
    else
    {
      if (playerRedBox.transform.position.x >= 1.5f)
      {
        playerRedBox.transform.position = transform.position;
      }
      else if (playerBlueBox.transform.position.x >= 1.5f)
      {
        playerBlueBox.transform.position = transform.position;
      }
      transform.position = new Vector3(2f,-3.5f,0f);
    }
	}

    // Start is called before the first frame update
    void Start()
    {
      transform.position = new Vector3(2f,-3.5f,0f);
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

    }
}
