using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
//CameraのProjectionはOrthographicに。

public class DFposition3 : MonoBehaviour,IDragHandler
{
	GameObject DFposition2;
	GameObject DFposition1;
	GameObject DFposition4;
	GameObject DFposition5;
	GameObject DFposition6;

	public void OnDrag(PointerEventData data){
		Vector3 TargetPos = Camera.main.ScreenToWorldPoint (data.position);
		TargetPos.z = 0f;

		transform.position = new Vector3
		(
			Mathf.Clamp(TargetPos.x, -2f, 2f),
			Mathf.Clamp(TargetPos.y, -2.5f, -0.5f),
			3f
		);

	}

    void Start()
    {
      DontDestroyOnLoad(this);
			DFposition2 = GameObject.FindWithTag("DFposition2");
			DFposition1 = GameObject.FindWithTag("DFposition1");
			DFposition4 = GameObject.FindWithTag("DFposition4");
			DFposition5 = GameObject.FindWithTag("DFposition5");
			DFposition6 = GameObject.FindWithTag("DFposition6");
    }

		void Update()
		{
			transform.position = new Vector3
	    (
	      Mathf.Clamp(transform.position.x, -2f, 2f),
	      Mathf.Clamp(transform.position.y, -2.5f, -0.5f),
	      3f
	    );

      if(transform.position == DFposition2.transform.position)
      {
        transform.position = new Vector3(-1f,-1.5f,3f);
      }
      if(transform.position == DFposition1.transform.position)
      {
        transform.position = new Vector3(-1f,-1.5f,3f);
      }
      if(transform.position == DFposition4.transform.position)
      {
        transform.position = new Vector3(-1f,-1.5f,3f);
      }
      if(transform.position == DFposition5.transform.position)
      {
        transform.position = new Vector3(-1f,-1.5f,3f);
      }
      if(transform.position == DFposition6.transform.position)
      {
        transform.position = new Vector3(-1f,-1.5f,3f);
      }

		}

}
