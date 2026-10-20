using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static ItemInventory;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Inventory : MonoBehaviour
{
    // Diccionario que guarda cada tipo de fruta y su cantidad
    private Dictionary<ItemId, int> inventory =
        new Dictionary<ItemId, int>();
    private Queue<string> inventario = new Queue<string>();

    [SerializeField] private TextMeshProUGUI tFruit;
    [SerializeField] private TextMeshProUGUI tScore;
    [SerializeField] private int fruit = 10;
    [SerializeField] private Image barraFruit;

    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private GameObject flame;
    [SerializeField] private GameObject spawnPointFlame;
    bool isAlive = true;
    float flameMovement = 10f;


    public void Victoria()
    {
        SceneManager.LoadScene("Victoria");
    }


    public bool CheckMaxItem(ItemId itemId)
    {
        if (inventory.ContainsKey(itemId))
        {
            if (inventory[itemId] >= 10)
            {
                return false;
                

            }/*
            if (inventory[itemId] == 0)
            {

                Instantiate(enemy, spawnPoint.transform.position, spawnPoint.transform.rotation);


            }*/
            return true;

        }

        return true;
    }


    public void AddItem(ItemId itemId, int cantidad)
    {
        if (inventory.ContainsKey(itemId))
        {
            inventory[itemId] -= cantidad;
            fruit--;
            tFruit.text = fruit.ToString();
           // tScore.text = fruit.ToString();
            barraFruit.fillAmount = fruit / 10f;
            //ScoreManager.Instance.AddScore(10);
            if (fruit == 0) {
                Victoria();
            }
        }
        else
        {
            inventory.Add(itemId, cantidad);
        }


    }
    
}
    
