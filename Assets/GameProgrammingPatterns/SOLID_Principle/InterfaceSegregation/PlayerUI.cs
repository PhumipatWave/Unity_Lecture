using UnityEngine;

namespace Interface
{
    // Interface Segregation Principle
    // "Many client specific interface are better than one general purpose interface"

    public interface IHealthDisplay { }
    public interface IDamageable { }

    public class HealthUI : IHealthDisplay, IDamageable { }
}