using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyWhiteOFparticle : MonoBehaviour
{

  private float normalPower;
  private float weakPower;
  private float strongPower;

  void OnParticleCollision(GameObject obj)
  {
    if(obj.GetComponent<DamageScript>().Element == "red")
    {
      obj.GetComponent<DamageScript>().Damage(weakPower);
    }
    else if(obj.GetComponent<DamageScript>().Element == "black")
    {
      obj.GetComponent<DamageScript>().Damage(strongPower);
    }
    else
    {
      obj.GetComponent<DamageScript>().Damage(normalPower);
    }

  }

    // Start is called before the first frame update
    void Start()
    {
      normalPower = 50;
      weakPower = normalPower * 0.8f;
      strongPower = normalPower * 1.2f;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
