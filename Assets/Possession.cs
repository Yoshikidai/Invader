using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NCMB;
using System.Linq;

public class Possession : MonoBehaviour
{
  public static int possession;
  string possessionString;
  public Text possessionText;

  public static int getPossession()
  {
    return possession;
  }

    // Start is called before the first frame update
    void Start()
    {
      possession = PlayerPrefs.GetInt("possession", 0);

    }

    // Update is called once per frame
    void Update()
    {
      possessionString = string.Format("{0:#,0}", possession);
      possessionText.text = possessionString;

    }
}
