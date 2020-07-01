using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
//CameraのProjectionはOrthographicに。

public class DFposition : MonoBehaviour,IDragHandler {

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
			
    }

		void Update()
		{
			transform.position = new Vector3
	    (
	      Mathf.Clamp(transform.position.x, -2f, 2f),
	      Mathf.Clamp(transform.position.y, -2.5f, -0.5f),
	      3f
	    );

		}

}
