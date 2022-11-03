using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int enemyCount = 1 , enemySpawnCount = 1; // Level'da o dalgada var olan d�?man say?m?z ve bir sonraki dalgada olu?turulacak d�?man say?s?.
    private Vector3 spawnPoint;                      // D�?man?n olu?aca?? nokta
    public GameObject enemy;                        // D�?man?m?z?n Referans?
                                                   
    public static GameManager Instance;           // Bu s?n?f?n metotlar?na bir di?er kod par�as?ndan ula?mak i�in olu?turdu?umuz nesne -> pointer(i?aret�i)
                                                 
    private void Awake()                       
    {                                         
        CreateEnemy(enemySpawnCount);        // Sahnemiz ba?lad???nda 1 tane d�?man olu?turmak i�in awake'e d�?man? olu?turan kodu �a??r?yoruz.
        Instance = this;                    // Pointer'a d??ar?dan ula??ld???nda nesnenin hangi s?n?ftan t�retildi?ini bu class'a (GameManager) tan?mlayarak belirliyoruz.
    }
    /// <EnemyDestroyed>
    /// d�?man say?s?n? kontrol ediyoruz
    /// </EnemyDestroyed>
    public void EnemyDestroyed()
    {
        if(enemyCount > 0)
        {
            enemyCount--;
            if(enemyCount == 0)
            {
                enemySpawnCount++;
                enemyCount = enemySpawnCount;
                CreateEnemy(enemySpawnCount);
            }
        }
    }
    /// <CreateEnemy>
    /// d�?man olu?turuyoruz
    /// </CreateEnemy>
    /// <param name="count"> olu?turulacak d�?man say?s?</param>
    void CreateEnemy(int count) 
    {
        for(int i = 0; i < count; i++)
        {
            spawnPoint = new Vector3(Random.Range(-5, 5), 10, Random.Range(-5, 5));
            Instantiate(enemy, spawnPoint, enemy.transform.rotation);
        }
        
    }
}
