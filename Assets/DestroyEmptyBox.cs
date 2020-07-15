using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEmptyBox : MonoBehaviour
{
  GameObject[] emptyOFbox;

  public void OnClick()
  {
    emptyOFbox = GameObject.FindGameObjectsWithTag("emptyBox");

    for(int i = 0; i < emptyOFbox.Length; ++i)
    {
      Destroy(emptyOFbox[i].gameObject);
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
