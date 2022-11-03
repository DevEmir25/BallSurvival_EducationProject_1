using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int enemyCount = 1 , enemySpawnCount = 1; // Level'da o dalgada var olan dü?man say?m?z ve bir sonraki dalgada olu?turulacak dü?man say?s?.
    private Vector3 spawnPoint;                      // Dü?man?n olu?aca?? nokta
    public GameObject enemy;                        // Dü?man?m?z?n Referans?
                                                   
    public static GameManager Instance;           // Bu s?n?f?n metotlar?na bir di?er kod parças?ndan ula?mak için olu?turdu?umuz nesne -> pointer(i?aretçi)
                                                 
    private void Awake()                       
    {                                         
        CreateEnemy(enemySpawnCount);        // Sahnemiz ba?lad???nda 1 tane dü?man olu?turmak için awake'e dü?man? olu?turan kodu ça??r?yoruz.
        Instance = this;                    // Pointer'a d??ar?dan ula??ld???nda nesnenin hangi s?n?ftan türetildi?ini bu class'a (GameManager) tan?mlayarak belirliyoruz.
    }
    /// <EnemyDestroyed>
    /// dü?man say?s?n? kontrol ediyoruz
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
    /// dü?man olu?turuyoruz
    /// </CreateEnemy>
    /// <param name="count"> olu?turulacak dü?man say?s?</param>
    void CreateEnemy(int count) 
    {
        for(int i = 0; i < count; i++)
        {
            spawnPoint = new Vector3(Random.Range(-5, 5), 10, Random.Range(-5, 5));
            Instantiate(enemy, spawnPoint, enemy.transform.rotation);
        }
        
    }
}
