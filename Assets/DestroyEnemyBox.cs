using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemyBox : MonoBehaviour
{
  GameObject enemyOFbox1;
  GameObject enemyOFbox2;
  GameObject enemyOFbox3;
  GameObject enemyOFbox4;
  private int enemyBoxNumber;

  public void OnClick()
  {
    enemyBoxNumber = EditPosition.getEnemyBoxNumber();

    if(enemyBoxNumber == 1)
    {
      enemyOFbox2 = GameObject.FindWithTag("enemyBox2");
      enemyOFbox3 = GameObject.FindWithTag("enemyBox3");
      enemyOFbox4 = GameObject.FindWithTag("enemyBox4");

    }
    else if(enemyBoxNumber == 2)
    {
      enemyOFbox1 = GameObject.FindWithTag("enemyBox1");
      enemyOFbox3 = GameObject.FindWithTag("enemyBox3");
      enemyOFbox4 = GameObject.FindWithTag("enemyBox4");

    }
    else if(enemyBoxNumber == 3)
    {
      enemyOFbox1 = GameObject.FindWithTag("enemyBox1");
      enemyOFbox2 = GameObject.FindWithTag("enemyBox2");
      enemyOFbox4 = GameObject.FindWithTag("enemyBox4");

    }
    else if(enemyBoxNumber == 4)
    {
      enemyOFbox1 = GameObject.FindWithTag("enemyBox1");
      enemyOFbox2 = GameObject.FindWithTag("enemyBox2");
      enemyOFbox3 = GameObject.FindWithTag("enemyBox3");

    }

    Destroy(enemyOFbox1);
    Destroy(enemyOFbox2);
    Destroy(enemyOFbox3);
    Destroy(enemyOFbox4);

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
