using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBlackDFparticle : MonoBehaviour
{

  float normalPower;
  private float weakPower;
  private float strongPower;

    void OnParticleCollision(GameObject obj)
    {
        if(obj.GetComponent<DamageScript>().Element == "white")
        {
          obj.GetComponent<DamageScript>().Damage(weakPower);
        }
        else if(obj.GetComponent<DamageScript>().Element == "blue")
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
      normalPower = PlayerPrefs.GetInt("BlackDefenceATK", 300);
      weakPower = normalPower * 0.8f;
      strongPower = normalPower * 1.2f;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
