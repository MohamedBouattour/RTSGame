using UnityEngine;

[System.Serializable]
public class Skill
{
    public string name;
    public string description;
    public int cost;
    public string[] dependencies;
    public Sprite icon;

    public bool isUnlocked;

    public Skill(string name, string description, int cost, string[] dependencies, Sprite icon, bool isUnlocked = false)
    {
        this.name = name;
        this.description = description;
        this.cost = cost;
        this.dependencies = dependencies;
        this.icon = icon;
        this.isUnlocked = isUnlocked;
    }
}

[System.Serializable]
public class SkillTree
{
    public string name;
    public int classPoints;
    public Skill[] skills;
    public string[] dependencies;
    public Sprite image;

    public SkillTree(string name, Sprite image)
    {
        this.name = name;
        classPoints = 0;
        skills = new Skill[0];
        this.image = image;
    }

    public void AddSkill(string name, string description, int cost, string[] dependencies, Sprite image)
    {
        Skill newSkill = new Skill(name, description, cost, dependencies, image);
        Skill[] newArray = new Skill[skills.Length + 1];
        for (int i = 0; i < skills.Length; i++)
        {
            newArray[i] = skills[i];
        }
        newArray[skills.Length] = newSkill;
        skills = newArray;
    }

    public void GainclassPoints(int amount)
    {
        classPoints += amount;
    }
}
