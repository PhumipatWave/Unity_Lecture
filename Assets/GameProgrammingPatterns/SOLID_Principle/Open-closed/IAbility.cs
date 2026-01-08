using UnityEngine;

namespace OpenClosed
{
    // Open-Closed Principle
    // "Open for extension, but closed for modification"
    // เปิดให้ “ขยาย” แต่ปิดไม่ให้ “แก้โค้ดเดิม”

    public interface IAbility
    {
        public void Use();
    }

    public class AbilityRunner : MonoBehaviour
    {
        private IAbility ability;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                // Open for extension, but closed for modification
                ability = new NormalAbility();
                UseAbility(ability);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                ability = new SpecialAbility();
                UseAbility(ability);
            }
        }

        public void UseAbility(IAbility ability)
        {
            ability.Use();
        }
    }

    public class NormalAbility : IAbility
    {
        public void Use()
        {
            Debug.Log("Walk");
        }
    }

    public class SpecialAbility : IAbility
    {
        public void Use()
        {
            Debug.Log("Fly");
        }
    }
}