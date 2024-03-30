using System;
using System.Collections.Generic;
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

public class SkillManager : MonoBehaviour
{

    public SkillTree kitchenManSkillTree;
    public SkillTree explorerSkillTree;
    public SkillTree shelterSkillTree;
    public SkillTree doctorSkillTree;
    public SkillTree collectorSkillTree;

    public GameObject skillPrefab;
    public GameObject treesRoot;

    public Dictionary<string, PlayableClass> playableClasses = new Dictionary<string, PlayableClass>();

    // Start is called before the first frame update
    void Start()
    {
        playableClasses.Add("KitchenMan", new KitchenMan());
        playableClasses.Add("Explorer", new Explorer());
        playableClasses.Add("Shelter", new Shelter());
        playableClasses.Add("Doctor", new Doctor());
        playableClasses.Add("Collector", new Collector());

        renderClasses();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void renderClasses()
    {
        foreach (string playableClassName in playableClasses.Keys)
        {
            GameObject skillObject = Instantiate(skillPrefab, treesRoot.transform);
            skillObject.SetActive(true);
            Image skillImage = skillObject.GetComponentInChildren<Image>();
            Sprite icon = Resources.Load<Sprite>("Sprites/" + playableClassName);
            if (skillImage != null && icon != null)
            {
                skillImage.sprite = icon;
            }
        }
    }
}
