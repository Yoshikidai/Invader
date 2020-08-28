using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorial : MonoBehaviour
{
  public Button right;
  public Button left;
  public GameObject tutorial1;
  public GameObject tutorial2;
  public GameObject tutorial3;
  public GameObject tutorial4;
  public GameObject tutorial5;
  public GameObject tutorial6;
  public static int number;

    // Start is called before the first frame update
    void Start()
    {
      number = 1;
    }

    // Update is called once per frame
    void Update()
    {
      if(number == 1)
      {
        left.enabled = false;
        tutorial1.SetActive(true);
        tutorial2.SetActive(false);
        tutorial3.SetActive(false);
        tutorial4.SetActive(false);
        tutorial5.SetActive(false);
        tutorial6.SetActive(false);

      }
      if(number == 2)
      {
        left.enabled = true;
        tutorial1.SetActive(false);
        tutorial2.SetActive(true);
        tutorial3.SetActive(false);
        tutorial4.SetActive(false);
        tutorial5.SetActive(false);
        tutorial6.SetActive(false);

      }
      if(number == 3)
      {
        tutorial1.SetActive(false);
        tutorial2.SetActive(false);
        tutorial3.SetActive(true);
        tutorial4.SetActive(false);
        tutorial5.SetActive(false);
        tutorial6.SetActive(false);

      }
      if(number == 4)
      {
        tutorial1.SetActive(false);
        tutorial2.SetActive(false);
        tutorial3.SetActive(false);
        tutorial4.SetActive(true);
        tutorial5.SetActive(false);
        tutorial6.SetActive(false);

      }
      if(number == 5)
      {
        right.enabled = true;
        tutorial1.SetActive(false);
        tutorial2.SetActive(false);
        tutorial3.SetActive(false);
        tutorial4.SetActive(false);
        tutorial5.SetActive(true);
        tutorial6.SetActive(false);

      }
      if(number == 6)
      {
        right.enabled = false;
        tutorial1.SetActive(false);
        tutorial2.SetActive(false);
        tutorial3.SetActive(false);
        tutorial4.SetActive(false);
        tutorial5.SetActive(false);
        tutorial6.SetActive(true);

      }

    }
}
