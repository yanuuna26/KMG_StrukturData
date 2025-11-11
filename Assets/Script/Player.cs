using UnityEngine;
[System.Serializable]
public class Player
{
    public string name;
    public int level;
    public int health;

    public Player(string name, int level, int health)
    {
        this.name = name;
        this.level = level;
        this.health = health;
    }

}
