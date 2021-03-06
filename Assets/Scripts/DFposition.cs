using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
//CameraのProjectionはOrthographicに。

public class DFposition : MonoBehaviour,IDragHandler
{
	GameObject DFposition1;
	GameObject DFposition2;
	GameObject DFposition3;
	GameObject DFposition4;
	GameObject DFposition5;
	GameObject DFposition6;

	public void OnDrag(PointerEventData data){
		Vector3 TargetPos = Camera.main.ScreenToWorldPoint (data.position);
		TargetPos.z = 0f;

		if
		(
			(Vector3.Distance(transform.position, DFposition1.transform.position) > 0.3f)
			&& (Vector3.Distance(transform.position, DFposition2.transform.position) > 0.3f)
			&& (Vector3.Distance(transform.position, DFposition3.transform.position) > 0.3f)
			&& (Vector3.Distance(transform.position, DFposition4.transform.position) > 0.3f)
			&& (Vector3.Distance(transform.position, DFposition5.transform.position) > 0.3f)
			&& (Vector3.Distance(transform.position, DFposition6.transform.position) > 0.3f)
		)
		{
			transform.position = new Vector3
			(
				Mathf.Clamp(TargetPos.x, -2f, 2f),
				Mathf.Clamp(TargetPos.y, -2.5f, -0.5f),
				3f
			);

		}

	}

    void Start()
    {
      DontDestroyOnLoad(this);
			DFposition1 = GameObject.FindWithTag("DFposition1");
			DFposition2 = GameObject.FindWithTag("DFposition2");
			DFposition3 = GameObject.FindWithTag("DFposition3");
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

		}

}
