using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class backButton : MonoBehaviour
{

    public void OnClick()
    {
      SceneController.bossStage = 1;
      SceneManager.LoadScene("ModeSelectScene");
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
