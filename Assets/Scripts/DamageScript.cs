using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{

  public string Element;
  public float HitPoint;
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

    }

    // Update is called once per frame
    void Update()
    {

    }
}
