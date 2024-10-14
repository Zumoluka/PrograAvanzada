using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillFactory : MonoBehaviour
{
    [SerializeField] private Skill[] skills;
    private Dictionary<string, Skill> skillsByName;

    private void Awake()
    {
        skillsByName = new Dictionary<string, Skill>();

        foreach (var skill in skills)
        {
            skillsByName.Add(skill.skillName, skill);
        }
    }
    public Skill CreateSkill(string skillName, Transform playerTransform)
    {
        if (skillsByName.TryGetValue(skillName, out Skill skillPrefab))
        {
            Skill skillInstance = Instantiate(skillPrefab, playerTransform.position, Quaternion.identity);
            return skillInstance;
        }
        else
        {
            Debug.LogWarning($"La habilidad '{skillName}' no existe.");
            return null;
        }
    }
}
