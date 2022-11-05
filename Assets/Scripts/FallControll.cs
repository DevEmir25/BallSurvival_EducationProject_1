using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallControll : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) //Collider ile etkilesime girdigi anda bu metot calisir
    {
        if (other.tag == "Player")  // eger player tagý olan obje ile etkilesime girdiyse
        {
            other.gameObject.SetActive(false); // düsmanlarý yok et
            SceneManager.LoadScene(0);  // sahneyi tekrardan yukle
        }
        else // eger player tagý olmayan bir obje collider ile etkilesime girdiyse
        {
            Destroy(other.gameObject);  // etkilesime giren objeyi yok et
            GameManager.Instance.EnemyDestroyed();  //GameManager scriptinde ki EnemyDestroyed metotunu calistir
        }
    }
}
