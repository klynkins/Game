using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public class EnemyCreationException : Exception
    {
        public EnemyCreationException(string message, string enemyName) : base(message)
        {
            RequestedEnemyName = enemyName;
        }

        public string RequestedEnemyName { get; private set; }
    }
}

