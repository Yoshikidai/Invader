using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startBattle : MonoBehaviour
{
  GameObject[] objects;

  public void OnClick()
  {
    // 指定したオブジェクトを削除
    for(int i = 0; i < objects.Length; ++i)
    {
    	Destroy(objects[i].gameObject);
    }

    SceneManager.LoadScene("Invader");
  }

    // Start is called before the first frame update
    void Start()
    {
      objects = GameObject.FindGameObjectsWithTag("DFposition");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
