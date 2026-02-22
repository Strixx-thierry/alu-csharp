using System;

namespace Enemies
{
    /// <summary>
    /// Defines a zombie with health, name, and property for name.
    /// </summary>
    public class Zombie
    {
        /// <summary>Health of the zombie.</summary>
        private int health;

        /// <summary>Name of the zombie.</summary>
        private string name = "(No name)";

        /// <summary>
        /// Gets or sets the name of the zombie.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

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
