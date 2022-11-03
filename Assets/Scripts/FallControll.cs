using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallControll : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)//tetiklenme ba?lang?c?nda çal???r
    {
        if (other.tag == "Player")// oyuncuyla çarp??t???nda
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
