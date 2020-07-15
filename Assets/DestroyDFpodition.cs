using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDFpodition : MonoBehaviour
{

  GameObject DFposition1;
  GameObject DFposition2;
  GameObject DFposition3;
  GameObject DFposition4;
  GameObject DFposition5;
  GameObject DFposition6;

  public void OnClick()
  {
    DFposition1 = GameObject.FindWithTag("DFposition1");
    DFposition2 = GameObject.FindWithTag("DFposition2");
    DFposition3 = GameObject.FindWithTag("DFposition3");
    DFposition4 = GameObject.FindWithTag("DFposition4");
    DFposition5 = GameObject.FindWithTag("DFposition5");
    DFposition6 = GameObject.FindWithTag("DFposition6");
    Destroy(DFposition1);
    Destroy(DFposition2);
    Destroy(DFposition3);
    Destroy(DFposition4);
    Destroy(DFposition5);
    Destroy(DFposition6);
  }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
