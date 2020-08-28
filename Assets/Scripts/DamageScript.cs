using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
  public string Position;
  public string Element;
  private float HitPoint;
  public GameObject particleObjectHit;
  public GameObject particleObjectExplosion;
  public AudioClip explosionSE;


  public void Damage(float damage)
  {
    HitPoint -= damage * 0.03f;

    Instantiate(
        particleObjectHit,
        new Vector3(transform.position.x, transform.position.y, -3f),
        particleObjectHit.transform.rotation
    ); //パーティクル用ゲームオブジェクト生成

    if(HitPoint <= 0)
    {
      if(Position == "OF")
      {
        PlayerPrefs.SetInt("destroyPlayer", PlayerPrefs.GetInt("destroyPlayer", 0) + 1);
      }
      if(Position == "DF")
      {
        PlayerPrefs.SetInt("destroyPlayer", PlayerPrefs.GetInt("destroyPlayer", 0) + 1);
      }

      if(Position == "enemyOF")
      {
        PlayerPrefs.SetInt("destroyEnemy", PlayerPrefs.GetInt("destroyEnemy", 0) + 1);
      }
      if(Position == "enemyDF")
      {
        PlayerPrefs.SetInt("destroyEnemy", PlayerPrefs.GetInt("destroyEnemy", 0) + 1);
      }

      PlayerPrefs.Save();

      Instantiate(
          particleObjectExplosion,
          new Vector3(transform.position.x, transform.position.y, -3f),
          particleObjectExplosion.transform.rotation
      ); //パーティクル用ゲームオブジェクト生成

      // オーディオを再生
      AudioSource.PlayClipAtPoint(explosionSE, transform.position);

      Destroy(this.gameObject);
    }

  }

    // Start is called before the first frame update
    void Start()
    {
      if(Position == "DF")
      {
        if(Element == "white")
        {
          HitPoint = PlayerPrefs.GetInt("WhiteDefenceHP", 500);
        }
        if(Element == "black")
        {
          HitPoint = PlayerPrefs.GetInt("BlackDefenceHP", 500);
        }
        if(Element == "blue")
        {
          HitPoint = PlayerPrefs.GetInt("BlueDefenceHP", 500);
        }
        if(Element == "red")
        {
          HitPoint = PlayerPrefs.GetInt("RedDefenceHP", 500);
        }

      }
      if(Position == "enemyDF")
      {
        HitPoint = 500;
      }
      if(Position == "OF")
      {
        if(Element == "white")
        {
          HitPoint = PlayerPrefs.GetInt("WhiteOffenceHP", 50);
        }
        if(Element == "black")
        {
          HitPoint = PlayerPrefs.GetInt("BlackOffenceHP", 50);
        }
        if(Element == "blue")
        {
          HitPoint = PlayerPrefs.GetInt("BlueOffenceHP", 50);
        }
        if(Element == "red")
        {
          HitPoint = PlayerPrefs.GetInt("RedOffenceHP", 50);
        }

      }
      if(Position == "enemyOF")
      {
        HitPoint = 50;
      }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
