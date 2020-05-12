using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.earthshaping.thirdperson.controller
{
    public class Projectile : MonoBehaviour
    {
        public float Lifetime = 10.0f;

        void Start()
        {
            StartCoroutine(KillAfter(Lifetime));
        }

        IEnumerator KillAfter(float seconds)
        {
            yield return new WaitForSeconds(seconds);
            Destroy(this.gameObject);
        }
    }
}
