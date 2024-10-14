using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillActivator : MonoBehaviour
{
    public SkillFactory skillFactory;
    public Transform playerTransform;

    public void OnSkillButtonClicked(string skillName)
    {
        Skill skill = skillFactory.CreateSkill(skillName, playerTransform);
        if (skill != null)
        {
            skill.Activate();
        }
    }
}
