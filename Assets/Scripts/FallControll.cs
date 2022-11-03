using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallControll : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)//tetiklenme ba?lang?c?nda �al???r
    {
        if (other.tag == "Player")// oyuncuyla �arp??t???nda
        {
            other.gameObject.SetActive(false);
            SceneManager.LoadScene(0);
        }
        else
        {
            Destroy(other.gameObject);
            GameManager.Instance.EnemyDestroyed();
        }
    }
}
