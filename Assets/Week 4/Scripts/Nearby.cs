using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    public string name; 
    public Vector3 position; 

    public Enemy(string name, Vector3 position)
    {
        this.name = name;
        this.position = position;
    }
}

public class Item
{
    public string name; 
    public Vector3 position; 

    public Item(string name, Vector3 position)
    {
        this.name = name;
        this.position = position;
    }
}
public class Nearby : MonoBehaviour
{
    private Vector3 playerPosition = new Vector3(0, 0, 0);

    // List

    private List<Enemy> enemies = new List<Enemy>
    {
        new Enemy("Enemy1", new Vector3(1, 0, 2)),
        new Enemy("Enemy2", new Vector3(4, 0, 3)),
        new Enemy("Enemy3", new Vector3(2, 0, 1)),
    };

    // List item
    private List<Item> items = new List<Item>
    {
        new Item("Item1", new Vector3(1, 0, 1)),
        new Item("Item2", new Vector3(3, 0, 2)),
        new Item("Item3", new Vector3(0, 0, 5)),
    };
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Tìm kẻ địch gần nhất
        BaiTap2(); // Tìm vật phẩm gần nhất
    }

    // Bài Tập 1: Tìm Kẻ Địch Gần Nhất
    void BaiTap1()
    {
        // Tạo danh sách các kẻ địch với tọa độ (x, y, z) trong không gian 3D
        // Vị trí của người chơi được cung cấp
        // Sử dụng công thức khoảng cách Euclid hoặc Vector3.Distance() để tính khoảng cách
        // So sánh khoảng cách và tìm kẻ địch gần nhất
        // Trả về thông tin của kẻ địch gần nhất
        {
           
            Enemy nearestEnemy = null; 
            float closestDistance = float.MaxValue;

            
            foreach (Enemy enemy in enemies)
            {
                
                float distance = Vector3.Distance(playerPosition, enemy.position);

                
                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    nearestEnemy = enemy; 
                }
            }

           
            if (nearestEnemy != null)
            {
                Debug.Log("Enemy nearest: " + nearestEnemy.name);
            }
            else
            {
                Debug.Log("not found!");
            }
        }
    }

    // Bài Tập 2: Tìm Vật Phẩm Gần Nhất
    void BaiTap2()
    {
        // Tạo danh sách các vật phẩm với tọa độ (x, y) trong không gian 2D
        // Vị trí của người chơi được cung cấp
        // Tính khoảng cách từ người chơi đến từng vật phẩm
        // So sánh để tìm vật phẩm gần nhất
        // Trả về thông tin của vật phẩm gần nhất
        {
            
            Item nearestItem = null; 
            float closestDistance = float.MaxValue; 

            
            foreach (Item item in items)
            {
                
                float distance = Vector3.Distance(playerPosition, item.position);

                
                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    nearestItem = item; 
                }
            }

           
            if (nearestItem != null)
            {
                Debug.Log("item nearest: " + nearestItem.name);
            }
            else
            {
                Debug.Log("not found");
            }
        }
    }
}
