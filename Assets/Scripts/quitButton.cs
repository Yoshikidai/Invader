using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitButton : MonoBehaviour
{

    //　ゲーム終了ボタンを押したら実行する
  public void EndGame() {
  	#if UNITY_EDITOR
  		UnityEditor.EditorApplication.isPlaying = false;
  	#else
  		Application.Quit();
  	#endif
  }

  public void OnClick()
  {
    EndGame();
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
