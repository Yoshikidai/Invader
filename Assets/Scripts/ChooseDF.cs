using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseDF : MonoBehaviour
{
  GameObject[] DFposition;

    // Start is called before the first frame update
    void Start()
    {
      DFposition = GameObject.FindGameObjectsWithTag("DFposition");
      for(int i = 0; i < DFposition.Length; ++i)
      {
        DFposition[i].SetActive(false);
      }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
