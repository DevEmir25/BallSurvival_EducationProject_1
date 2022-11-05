using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int enemyCount = 1 , enemySpawnCount = 1; // Dusman sayimiz ve bir sonraki turda olusacak dusman sayimiz
    private Vector3 spawnPoint;     // Dusmanin olusacagi nokta
    public GameObject enemy;         // Dusmani tanimladigimiz ve motorda atayacagimiz yer
                                                   
    public static GameManager Instance;  // Farkl� scriptlerden ulasabilmek icin tanimladigimiz performansli nesne   
                                                 
    private void Awake()                       
    {                                         
        CreateEnemy(enemySpawnCount);   //Sahnemiz basladiginda dusman olusturan kod
        Instance = this;     //Disardan bu scripte ulastigimizda scripti tekrardan g�zden gecirerek kodlar�n dogru calismasi icin gerekli kod 
    }
    public void EnemyDestroyed() // Kaydettigimiz ilerlemeye gore dusman sayimizi ayarladigimiz metot
    {
        if(enemyCount > 0) // Eger dusman sayimiz 0 dan buyukse
        {
            enemyCount--;  //Dusman sayimizi 1 azalt�r
            if(enemyCount == 0)    // Eger sahnede dusman kalmadiysa
            {
                enemySpawnCount++;   //Olusturulacak dusman sayisini 1 artt�r�r.
                enemyCount = enemySpawnCount; // Yeni dusman sayimiz olusacak dusman sayisina esit olur
                CreateEnemy(enemySpawnCount); // Create enemy metotunu olusacak dusman say�s� parametresi ile cal�st�r�yoruz
            }
        }
    }
    void CreateEnemy(int count) // Icine atayaca��m�z de�i�ken degeri kadar dusmani sahnemizde olusturacak metot.
    {
        for(int i = 0; i < count; i++) // Olusacak dusman sayisi kadar for donuyor 
        {
            spawnPoint = new Vector3(Random.Range(-5, 5), 10, Random.Range(-5, 5));  // Dusmanin olusacagi araligi belirliyoruz
            Instantiate(enemy, spawnPoint, enemy.transform.rotation);  //Instantiate metotu ile dusman olusturuyoruz.
        }
        
    }
}
