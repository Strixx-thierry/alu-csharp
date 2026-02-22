using System;

namespace Enemies
{
    /// <summary>
    /// Defines a zombie with private health and a getter method.
    /// </summary>
    public class Zombie
    {
        /// <summary>Health of the zombie.</summary>
        private int health;

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class with health 0.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class with specified health.
        /// </summary>
        /// <param name="value">Initial health value.</param>
        /// <exception cref="ArgumentException">Thrown when value is less than 0.</exception>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }

        /// <summary>
        /// Returns the health of the zombie.
        /// </summary>
        /// <returns>Current health value.</returns>
        public int GetHealth()
        {
            return health;
        }
    }
}
