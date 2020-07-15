using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGame : MonoBehaviour
{
  GameObject[] emptyOFbox;
  GameObject[] DF1;
  GameObject[] DF2;
  GameObject[] DF3;
  GameObject[] DF4;
  GameObject[] DF5;
  GameObject[] DF6;

  public GameObject FogParticle1;
  public GameObject FogParticle2;
  public GameObject AudioObject;

  private string stageName;

  public void OnClick()
  {
    stageName = SceneController.getStage();

    emptyOFbox = GameObject.FindGameObjectsWithTag("emptyBox");

    DF1 = GameObject.FindGameObjectsWithTag("playerDF1");
    DF2 = GameObject.FindGameObjectsWithTag("playerDF2");
    DF3 = GameObject.FindGameObjectsWithTag("playerDF3");
    DF4 = GameObject.FindGameObjectsWithTag("playerDF4");
    DF5 = GameObject.FindGameObjectsWithTag("playerDF5");
    DF6 = GameObject.FindGameObjectsWithTag("playerDF6");


    for(int i = 0; i < emptyOFbox.Length; ++i)
    {
      Destroy(emptyOFbox[i].gameObject);
    }

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

    Instantiate(
        FogParticle1,
        new Vector3(4f, -4f, -5f),
        transform.rotation
    );
    Instantiate(
        FogParticle2,
        new Vector3(-4f, -4f, -5f),
        transform.rotation
    );
    Instantiate(
        AudioObject,
        new Vector3(0f, 0f, -5f),
        transform.rotation
    );

    Time.timeScale = 1;


    if(stageName == "1_1" || stageName == "1_2" || stageName == "1_3" || stageName == "1_4" || stageName == "1_5"
    || stageName == "1_boss")
    {
      SceneManager.LoadScene("STAGE1");
    }

    if(stageName == "2_1" || stageName == "2_2" || stageName == "2_3" || stageName == "2_4" || stageName == "2_5"
    || stageName == "2_boss")
    {
      SceneManager.LoadScene("STAGE2");
    }

    if(stageName == "3_1" || stageName == "3_2" || stageName == "3_3" || stageName == "3_4" || stageName == "3_5"
    || stageName == "3_boss")
    {
      SceneManager.LoadScene("STAGE3");
    }

    if(stageName == "4_1" || stageName == "4_2" || stageName == "4_3" || stageName == "4_4" || stageName == "4_5"
    || stageName == "4_boss")
    {
      SceneManager.LoadScene("STAGE4");
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
