using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrawberryAdventure
{
    public sealed class TheGame
    {
        private static volatile TheGame instance;
        private static object syncRoot = new Object();

        public TheGame() {}

        public static TheGame GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new TheGame();
                    }
                }

                return instance;
            }
        }

        public Map[] Maps
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Character Hero
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private static void DamageCalculator()
        {
            throw new System.NotImplementedException();
        }
    }
}