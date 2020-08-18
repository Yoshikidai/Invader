using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textControl : MonoBehaviour
{
  Text text;
  float time;
    // Start is called before the first frame update
    void Start()
    {
      // Textコンポーネントを取得
      text = this.GetComponent<Text>();
      time = 0;
    }

    // Update is called once per frame
    void Update()
    {
      time += 0.1f;
      // 色を指定
      text.color = new Color(1.0f, 1.0f, 1.0f, 0.3f + Mathf.Sin(time) * 0.3f);

    }
}
