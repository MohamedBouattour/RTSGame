using UnityEngine;
using UnityEngine.UI;


public enum PlayerStats
{
    KitchenMan,
    Explorer,
    Shelter,
    Doctor,
    Collector
}

public class PlayerSkillManager : MonoBehaviour
{

    public SkillTree kitchenManSkillTree;
    public SkillTree explorerSkillTree;
    public SkillTree shelterSkillTree;
    public SkillTree doctorSkillTree;
    public SkillTree collectorSkillTree;

    public GameObject skillPrefab;


    // Start is called before the first frame update
    void Start()
    {
        kitchenManSkillTree = new SkillTree("KitchenMan", Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg"));
        initKitchenManSkillTree();
        explorerSkillTree = new SkillTree("Explorer", Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg"));
        iniExplorerSkillTree();
        shelterSkillTree = new SkillTree("Shelter", Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg"));
        initShelterSkillTree();
        doctorSkillTree = new SkillTree("Doctor", Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg"));
        initDoctorSkillTree();
        collectorSkillTree = new SkillTree("Collector", Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg"));
        initCollectorSkillTree();
        initSkillsUI();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void initSkillsUI()
    {
        foreach (Skill skill in kitchenManSkillTree.skills)
        {
            GameObject skillObject = Instantiate(skillPrefab, transform);
            skillObject.SetActive(true);
            Image skillImage = skillObject.GetComponentInChildren<Image>();
            Sprite icon = Resources.Load<Sprite>("Sprites/kitchenman");
            Debug.Log(icon);
            if (skillImage != null && icon != null)
            {
                skillImage.sprite = icon;
            }
        }
    }

    private void initKitchenManSkillTree()
    {
        kitchenManSkillTree.AddSkill("Culinary Mastery", "Unlocks the ability to create powerful dishes that provide temporary buffs to allies.", 1, new string[0], Resources.Load<Sprite>("Sprites/kitchenman"));
        kitchenManSkillTree.AddSkill("Ingredient Alchemy", "Learn to manipulate ingredients to create potions with various effects.", 2, new string[] { "Culinary Mastery" }, Resources.Load<Sprite>("Sprites/kitchenman"));
        kitchenManSkillTree.AddSkill("Kitchen Tools Proficiency", "Master the use of kitchen tools as weapons in combat.", 1, new string[0], Resources.Load<Sprite>("Sprites/kitchenman"));
        kitchenManSkillTree.AddSkill("Gourmet Empowerment", "Gain temporary buffs after consuming dishes you prepared.", 2, new string[] { "Culinary Mastery" }, Resources.Load<Sprite>("Sprites/kitchenman"));
    }

    private void iniExplorerSkillTree()
    {
        explorerSkillTree.AddSkill("Survival Instincts", "Increases chances of finding rare items while exploring.", 1, new string[0], Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg"));
        explorerSkillTree.AddSkill("Pathfinder", "Navigate through challenging terrain with ease.", 2, new string[0], Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg"));
        explorerSkillTree.AddSkill("Cartography", "Map out discovered areas for future reference.", 1, new string[0], Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg"));
        explorerSkillTree.AddSkill("Treasure Hunter", "Increases chances of finding hidden treasures.", 2, new string[] { "Survival Instincts" }, Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg"));
    }

    private void initShelterSkillTree()
    {
        shelterSkillTree.AddSkill("Fortification", "Improve the defense of your shelter against threats.", 1, new string[0], Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg"));
        shelterSkillTree.AddSkill("Resource Management", "Efficiently manage resources for building and maintaining the shelter.", 2, new string[0], Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg"));
        shelterSkillTree.AddSkill("Community Bond", "Strengthen the bonds among shelter residents, increasing morale.", 1, new string[0], Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg"));
        shelterSkillTree.AddSkill("Infrastructure", "Build essential infrastructure for the shelter's functionality.", 2, new string[] { "Fortification" }, Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg"));
    }

    private void initDoctorSkillTree()
    {
        doctorSkillTree.AddSkill("First Aid", "Administer basic first aid to heal minor injuries.", 1, new string[0], Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg"));
        doctorSkillTree.AddSkill("Medical Expertise", "Gain knowledge to diagnose and treat various illnesses.", 2, new string[] { "First Aid" }, Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg"));
        doctorSkillTree.AddSkill("Field Medic", "Treat injuries more effectively in the field.", 1, new string[0], Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg"));
        doctorSkillTree.AddSkill("Emergency Response", "Respond quickly to emergencies and crises.", 2, new string[] { "First Aid" }, Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg"));
    }

    private void initCollectorSkillTree()
    {
        collectorSkillTree.AddSkill("Scavenging", "Increase the efficiency of gathering resources from the environment.", 1, new string[0], Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg"));
        collectorSkillTree.AddSkill("Item Crafting", "Learn to craft useful items from collected materials.", 2, new string[] { "Scavenging" }, Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg"));
        collectorSkillTree.AddSkill("Trading", "Improve your ability to negotiate and trade with other characters.", 1, new string[0], Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg"));
        collectorSkillTree.AddSkill("Rare Findings", "Increases the chances of finding rare and valuable items.", 2, new string[] { "Scavenging" }, Resources.Load<Sprite>("./assets/images/KitchenMan.jpeg"));
    }
}
