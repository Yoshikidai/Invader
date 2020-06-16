using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
//CameraのProjectionはOrthographicに。

public class playerRedBox : MonoBehaviour,IDragHandler
{

  private playerYellowBox playerYellowBox;
  private playerBlueBox playerBlueBox;

  public void OnDrag(PointerEventData data){
		Vector3 TargetPos = Camera.main.ScreenToWorldPoint (data.position);
    if (TargetPos.x < -1.5f)
    {

      if (playerYellowBox.transform.position == new Vector3(-2f,-3.5f,0f))
      {
        playerYellowBox.transform.position = transform.position;
      }
      else if (playerBlueBox.transform.position == new Vector3(-2f,-3.5f,0f))
      {
        playerBlueBox.transform.position = transform.position;
      }

      transform.position = new Vector3(-2f,-3.5f,0f);

    }
    else if (TargetPos.x < -0.5f)
    {

      if (playerYellowBox.transform.position == new Vector3(-1f,-3.5f,0f))
      {
        playerYellowBox.transform.position = transform.position;
      }
      else if (playerBlueBox.transform.position == new Vector3(-1f,-3.5f,0f))
      {
        playerBlueBox.transform.position = transform.position;
      }

      transform.position = new Vector3(-1f,-3.5f,0f);
    }
    else if (TargetPos.x < 0.5f)
    {
      if (playerYellowBox.transform.position == new Vector3(0f,-3.5f,0f))
      {
        playerYellowBox.transform.position = transform.position;
      }
      else if (playerBlueBox.transform.position == new Vector3(0f,-3.5f,0f))
      {
        playerBlueBox.transform.position = transform.position;
      }

      transform.position = new Vector3(0f,-3.5f,0f);
    }
    else if (TargetPos.x < 1.5f)
    {
      if (playerYellowBox.transform.position == new Vector3(1f,-3.5f,0f))
      {
        playerYellowBox.transform.position = transform.position;
      }
      else if (playerBlueBox.transform.position == new Vector3(1f,-3.5f,0f))
      {
        playerBlueBox.transform.position = transform.position;
      }

      transform.position = new Vector3(1f,-3.5f,0f);
    }
    else
    {
      if (playerYellowBox.transform.position == new Vector3(2f,-3.5f,0f))
      {
        playerYellowBox.transform.position = transform.position;
      }
      else if (playerBlueBox.transform.position == new Vector3(2f,-3.5f,0f))
      {
        playerBlueBox.transform.position = transform.position;
      }
      transform.position = new Vector3(2f,-3.5f,0f);
    }
	}

    // Start is called before the first frame update
    void Start()
    {
      playerYellowBox = GameObject
                  .FindWithTag("playerYellowBox")
                  .GetComponent<playerYellowBox>();
      playerBlueBox = GameObject
                  .FindWithTag("playerBlueBox")
                  .GetComponent<playerBlueBox>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
