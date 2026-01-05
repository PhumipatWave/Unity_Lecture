using UnityEngine;

public class PlayerAbility : MonoBehaviour
{
    [SerializeField] private AbillityRunner abillityRunner;

    private void Awake()
    {
        abillityRunner = GetComponent<AbillityRunner>();
        abillityRunner.SetAbility(new NormalAbility());

        Debug.Log("Num1 : Rage, Num2 : Fireball, Num3 : Heal, Space : Use ability");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            abillityRunner.SetAbility(new RageAbility());
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            abillityRunner.SetAbility(new FireballAbility());
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            abillityRunner.SetAbility(new HealAbility());
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            abillityRunner.UseAbility();
        }
    }
}
