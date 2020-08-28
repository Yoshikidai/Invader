using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerWhiteOFparticle : MonoBehaviour
{

  float normalPower;
  private float weakPower;
  private float strongPower;
  private ParticleSystem ps;

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
      normalPower = PlayerPrefs.GetInt("WhiteOffenceATK", 50);
      weakPower = normalPower * 0.8f;
      strongPower = normalPower * 1.2f;

      ps = this.GetComponent<ParticleSystem>();
      ps.Stop();
      ParticleSystem.MainModule main = ps.main;
      main.duration = PlayerPrefs.GetInt("WhiteOffenceITV", 50) * 0.1f;
      ps.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
