using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToChooseDF : MonoBehaviour
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

    PlayerPrefs.SetFloat("x1",DFposition1.transform.position.x);
    PlayerPrefs.SetFloat("x2",DFposition2.transform.position.x);
    PlayerPrefs.SetFloat("x3",DFposition3.transform.position.x);
    PlayerPrefs.SetFloat("x4",DFposition4.transform.position.x);
    PlayerPrefs.SetFloat("x5",DFposition5.transform.position.x);
    PlayerPrefs.SetFloat("x6",DFposition6.transform.position.x);

    PlayerPrefs.SetFloat("y1",DFposition1.transform.position.y);
    PlayerPrefs.SetFloat("y2",DFposition2.transform.position.y);
    PlayerPrefs.SetFloat("y3",DFposition3.transform.position.y);
    PlayerPrefs.SetFloat("y4",DFposition4.transform.position.y);
    PlayerPrefs.SetFloat("y5",DFposition5.transform.position.y);
    PlayerPrefs.SetFloat("y6",DFposition6.transform.position.y);

    SceneManager.LoadScene("ChooseDF");

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
