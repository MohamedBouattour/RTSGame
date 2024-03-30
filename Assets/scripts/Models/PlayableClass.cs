using UnityEngine;
using System.Linq;
public abstract class PlayableClass
{
    protected string name;
    protected int classPoint;

    protected Skill[] skills;

    protected void unlockSkill(Skill targetSkill)
    {
        Skill foundSkill = skills.FirstOrDefault(skill => skill.name == targetSkill.name);
        if (foundSkill != null && !foundSkill.isUnlocked)
        {
            foundSkill.isUnlocked = true;
            this.classPoint++;
        }
    }


}

[System.Serializable]
public class KitchenMan : PlayableClass
{
    public KitchenMan(int classPoint = 0)
    {
        name = "KitchenMan";
        this.classPoint = classPoint;
        skills = new Skill[] {
        new Skill("Culinary Mastery", "Unlocks the ability to create powerful dishes that provide temporary buffs to allies.", 1, new string[0], Resources.Load<Sprite>("Sprites/kitchenman")) ,
        new Skill("Ingredient Alchemy", "Learn to manipulate ingredients to create potions with various effects.", 2, new string[] { "Culinary Mastery" }, Resources.Load<Sprite>("Sprites/kitchenman")),
        new Skill("Kitchen Tools Proficiency", "Master the use of kitchen tools as weapons in combat.", 1, new string[0], Resources.Load<Sprite>("Sprites/kitchenman")),
        new Skill("Gourmet Empowerment", "Gain temporary buffs after consuming dishes you prepared.", 2, new string[] { "Culinary Mastery" }, Resources.Load<Sprite>("Sprites/kitchenman"))
        };
    }
}

[System.Serializable]
public class Explorer : PlayableClass
{
    public Explorer(int classPoint = 0)
    {
        name = "Explorer";
        this.classPoint = classPoint;
        skills = new Skill[] {
        new Skill("Survival Instincts", "Increases chances of finding rare items while exploring.", 1, new string[0], Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg")) ,
        new Skill("Pathfinder", "Navigate through challenging terrain with ease.", 2, new string[0], Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg")),
        new Skill("Cartography", "Map out discovered areas for future reference.", 1, new string[0], Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg")),
        new Skill("Treasure Hunter", "Increases chances of finding hidden treasures.", 2, new string[] { "Survival Instincts" }, Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg"))
        };
    }
}


[System.Serializable]
public class Shelter : PlayableClass
{
    public Shelter(int classPoint = 0)
    {
        name = "Shelter";
        this.classPoint = classPoint;
        skills = new Skill[] {
        new Skill("Fortification", "Improve the defense of your shelter against threats.", 1, new string[0], Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg")),
        new Skill("Resource Management", "Efficiently manage resources for building and maintaining the shelter.", 2, new string[0], Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg")),
        new Skill("Community Bond", "Strengthen the bonds among shelter residents, increasing morale.", 1, new string[0], Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg")),
        new Skill("Infrastructure", "Build essential infrastructure for the shelter's functionality.", 2, new string[] { "Fortification" }, Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg"))
        };
    }
}


[System.Serializable]
public class Doctor : PlayableClass
{
    public Doctor(int classPoint = 0)
    {
        name = "Doctor";
        this.classPoint = classPoint;
        skills = new Skill[] {
         new Skill("First Aid", "Administer basic first aid to heal minor injuries.", 1, new string[0], Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg")),
         new Skill("Medical Expertise", "Gain knowledge to diagnose and treat various illnesses.", 2, new string[] { "First Aid" }, Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg")),
         new Skill("Field Medic", "Treat injuries more effectively in the field.", 1, new string[0], Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg")),
         new Skill("Emergency Response", "Respond quickly to emergencies and crises.", 2, new string[] { "First Aid" }, Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg"))
        };
    }
}

[System.Serializable]
public class Collector : PlayableClass
{
    public Collector(int classPoint = 0)
    {
        name = "Collector";
        this.classPoint = classPoint;
        skills = new Skill[] {
        new Skill("Scavenging", "Increase the efficiency of gathering resources from the environment.", 1, new string[0], Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg")),
        new Skill("Item Crafting", "Learn to craft useful items from collected materials.", 2, new string[] { "Scavenging" }, Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg")),
        new Skill("Trading", "Improve your ability to negotiate and trade with other characters.", 1, new string[0], Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg")),
        new Skill("Rare Findings", "Increases the chances of finding rare and valuable items.", 2, new string[] { "Scavenging" }, Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg"))
        };
    }
}