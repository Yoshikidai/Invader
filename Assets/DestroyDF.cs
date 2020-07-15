using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDF : MonoBehaviour
{
  GameObject[] DF1;
  GameObject[] DF2;
  GameObject[] DF3;
  GameObject[] DF4;
  GameObject[] DF5;
  GameObject[] DF6;

  public void OnClick()
  {
    DF1 = GameObject.FindGameObjectsWithTag("playerDF1");
    DF2 = GameObject.FindGameObjectsWithTag("playerDF2");
    DF3 = GameObject.FindGameObjectsWithTag("playerDF3");
    DF4 = GameObject.FindGameObjectsWithTag("playerDF4");
    DF5 = GameObject.FindGameObjectsWithTag("playerDF5");
    DF6 = GameObject.FindGameObjectsWithTag("playerDF6");

    // 指定したオブジェクトを削除
    for(int i = 0; i < DF1.Length; ++i)
    {
      Destroy(DF1[i].gameObject);
    }
    for(int i = 0; i < DF2.Length; ++i)
    {
      Destroy(DF2[i].gameObject);
    }
    for(int i = 0; i < DF3.Length; ++i)
    {
      Destroy(DF3[i].gameObject);
    }
    for(int i = 0; i < DF4.Length; ++i)
    {
      Destroy(DF4[i].gameObject);
    }
    for(int i = 0; i < DF5.Length; ++i)
    {
      Destroy(DF5[i].gameObject);
    }
    for(int i = 0; i < DF6.Length; ++i)
    {
      Destroy(DF6[i].gameObject);
    }
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
