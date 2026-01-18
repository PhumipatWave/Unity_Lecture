using UnityEngine;

namespace OptionalParameters
{
    public class OptionalParameters : MonoBehaviour
    {
        private const int DEFAULT_HEALTH = 100;

        private enum UnitType
        {
            Melee,
            Ranged,
            Wizard
        }

        void Start()
        {
            SpawnUnit();
            SpawnUnit(UnitType.Ranged);
            // Optional parameter : Can be write the name of parameter that want to set it
            SpawnUnit(UnitType.Wizard, healthAmount: 50);
        }

        // Optional parameter : Use for declare the initial value of parameter
        // The value must be Constance value
        // default : Set value to the default of that type
        private void SpawnUnit(UnitType unitType = UnitType.Melee, Vector3 spawnPos = default, Quaternion spawnRotation = default, int healthAmount = DEFAULT_HEALTH)
        {
            Debug.Log($"Spawning unit type : {unitType}\nHealth : {healthAmount}\nSpawn Position : {spawnPos}\nSpawn Rotation : {spawnRotation}");
        }
    }
}