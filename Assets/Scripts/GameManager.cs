using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int enemyCount = 1 , enemySpawnCount = 1; // Dusman sayimiz ve bir sonraki tur da olusacak dusman sayimiz
    private Vector3 spawnPoint;     // Dusmanin olusacagi nokta
    public GameObject enemy;         // Dusmani tanimladigimiz ve motorda atayacagimiz yer
                                                   
    public static GameManager Instance;  // Farklý scriptlerden ulasabilmek icin tanimladigimiz performansli nesne   
                                                 
    private void Awake()                       
    {                                         
        CreateEnemy(enemySpawnCount);   //Sahnemiz basladiginda dusman olusturan kod
        Instance = this;     //Disardan bu scripte ulastigimizda scripti tekrardan gözden gecirerek kodlarýn dogru calismasi icin gerekli kod 
    }
    /// <EnemyDestroyed>
    /// dü?man say?s?n? kontrol ediyoruz
    /// </EnemyDestroyed>
    public void EnemyDestroyed() // Kaydettigimiz ilerlemeye gore dusman sayimizi ayarladigimiz metot
    {
        if(enemyCount > 0) // Eger dusman sayimiz 0 dan buyukse
        {
            enemyCount--;  //Dusman sayimizi 1 azaltýr
            if(enemyCount == 0)    // Eger sahnede dusman kalmadiysa
            {
                enemySpawnCount++;   //Olusturulacak dusman sayisini 1 arttýrýr.
                enemyCount = enemySpawnCount; // Yeni dusman sayimiz olusacak dusman sayisina esit olur
                CreateEnemy(enemySpawnCount); // Create enemy metotunu olusacak dusman sayýsý parametresi ile calýstýrýyoruz
            }
        }
    }
    /// <CreateEnemy>
    /// dü?man olu?turuyoruz
    /// </CreateEnemy>
    /// <param name="count"> olu?turulacak dü?man say?s?</param>
    
    
    void CreateEnemy(int count) // Dusman olusturmak icin yazilan metot kac tane olusacagini belirlemek icin parametre de belirliyoruz
    {
        for(int i = 0; i < count; i++) // Olusacak dusman sayisi kadar for donuyor 
        {
            spawnPoint = new Vector3(Random.Range(-5, 5), 10, Random.Range(-5, 5));  // Dusmanin olusacagi noktayi belirliyoruz
            Instantiate(enemy, spawnPoint, enemy.transform.rotation);  //Instantiate metotu ile dusan olusturuyoruz.
        }
        
    }
}
