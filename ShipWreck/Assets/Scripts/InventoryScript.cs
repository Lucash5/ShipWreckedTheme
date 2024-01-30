using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InventoryScript : MonoBehaviour
{
    public Canvas invUI;
    List<string> inventory = new List<string>();
    string[] itemlist = { "Apple" };
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            invUI.enabled = true;
        }
    }

    bool owns;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        
        foreach (string item in itemlist)
        {
            
        
            if (item == collision.gameObject.name)
            {
               

                for (int i = 0; i < inventory.Count; i++)
                {
                    if (inventory[i] == item)
                    {
                        owns = true;

                        inventory[i + 1] = (int.Parse(inventory[i + 1]) + 1).ToString();
                    }
                }

                if (owns == false)
                {
                inventory.Add(item);
                inventory.Add("1");
                }

                foreach (string aaa in inventory)
                {
                    Debug.Log(aaa);
                }
                
                Destroy(collision.gameObject);
            }
        }
    }
}
