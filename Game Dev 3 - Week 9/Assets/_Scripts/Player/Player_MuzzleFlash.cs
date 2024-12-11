using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDevWithMarco.Player
{
    public class Player_MuzzleFlash : MonoBehaviour
    {
       public IEnumerator ReturnToThePool()
        {
            yield return new WaitForSeconds(1);

            gameObject.SetActive(false);
        }
    }
}
