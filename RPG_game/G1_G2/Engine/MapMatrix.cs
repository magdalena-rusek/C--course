﻿using System;
using System.Collections.Generic;
using Game.Engine.Monsters.MonsterFactories;
using Game.Engine.Monsters;
using System.Windows;
using Game.Engine.Interactions;

namespace Game.Engine
{
    // container class for an integer matrix that represents game map grid
    // map codes:
    // 0 - unpassable terrain (the character cannot go there)
    // 1 - normal terrain (walkable, but nothing happens)
    // 1000 - battle with a monster
    // 2000 to 2999 - portal to another map
    // 3000 and above - a custom interaction
    // -1 to -999 - unpassable terrain (just like 0 but with nicer display)
    
    [Serializable]
    class MapMatrix
    {
        // map parameters
        private int monsters = 10;
        private int walls = 10;

        // other fields and properties
        private Dictionary<int, MonsterFactory> monDict;
        private Random rng;
        private GameSession parentSession;
        public Dictionary<int, Monster> Monsters { get; set; }
        public Dictionary<int, Interaction> Interactions { get; private set; }
        public int[,] Matrix { get; set; }
        public int Width { get; set; } = 25;
        public int Height { get; set; } = 20;

        public MapMatrix(GameSession parent, List<int> portals, List<Interaction> inters, int randomCode)
        {
            parentSession = parent;
            Matrix = new int[Height, Width];
            rng = new Random(randomCode);
            // make map walkable
            for (int y = 1; y < Height - 1; y++)
            {
                for (int x = 1; x < Width - 1; x++)
                {
                    Matrix[y, x] = 1;
                }
            }
            // decorate map with stuff
            DecorateWithObstacles();
            DecorateWithPortals(portals);
            DecorateWithInteractions(inters);
            DecorateWithMonsters();
            // trim walls
            for (int y = 0; y < Height; y++) Matrix[y, 0] = 0;
            for (int x = 0; x < Width; x++) Matrix[0, x] = 0;
            for (int y = 0; y < Height; y++) Matrix[y, Width - 1] = 0;
            for (int x = 0; x < Width; x++) Matrix[Height - 1, x] = 0;
            // initialize 
            InitializeFactoryList();
            Monsters = new Dictionary<int, Monster>();
        }

        private void InitializeFactoryList()
        {
            monDict = new Dictionary<int, MonsterFactory>();
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++) 
                {
                    if (Matrix[y, x] == 1000)
                    {
                        monDict.Add(y * Width + x, Index.RandomMonsterFactory());
                    }
                }
            }
        }

        // produce or hint monsters
        public Monster CreateMonster(int x, int y, int playerLevel)
        {
            if (Monsters.ContainsKey(y * Width + x) && Monsters[y * Width + x] != null) return Monsters[y * Width + x];
            if (monDict.ContainsKey(y * Width + x) && monDict[y * Width + x] != null)
            {
                return monDict[y * Width + x].Create(playerLevel);
            }
            return null;
        }
        public System.Windows.Controls.Image HintMonsterImage(int x, int y)
        {
            if (monDict.ContainsKey(y * Width + x) && monDict[y * Width + x] != null)
            {
                return monDict[y * Width + x].Hint();
            }
            return null;
        }

        // decorate map with stuff
        private void DecorateWithObstacles()
        {
            // for cleaner code
            int y0 = 1;
            int ym = Height - 2;
            int x0 = 1;
            int xm = Width - 2;
            // external walls
            for (int y = y0; y < ym; y++)
            {
                Matrix[y, x0] = -1;
                Matrix[y, xm] = -1;
            }
            for (int x = x0; x <= xm; x++) // = is for edges
            {
                Matrix[y0, x] = -1;
                Matrix[ym, x] = -1;
            }
            // internal walls
            for (int i = 0; i < walls; i++)
            {
                int start, length;
                switch (rng.Next(4))
                {
                    case 0:
                        start = rng.Next(xm - x0 - 1);
                        length = rng.Next(1, Width / 2 - 2);
                        for (int l = 0; l < length; l++)
                        {
                            Matrix[y0 + l, start] = -1;
                        }
                        break;
                    case 1:
                        start = rng.Next(xm - x0 - 1);
                        length = rng.Next(1, Width / 2 - 2);
                        for (int l = 0; l < length; l++)
                        {
                            Matrix[ym - l, start] = -1;
                        }
                        break;
                    case 2:
                        start = rng.Next(ym - y0 - 1);
                        length = rng.Next(1, Height / 2 - 2);
                        for (int l = 0; l < length; l++)
                        {
                            Matrix[start, x0 + l] = -1;
                        }
                        break;
                    case 3:
                        start = rng.Next(ym - y0 - 1);
                        length = rng.Next(1, Height / 2 - 2);
                        for (int l = 0; l < length; l++)
                        {
                            Matrix[start, xm - l] = -1;
                        }
                        break;
                }
            }
            // keep passages open
            for (int x = x0 + 2; x < xm - 2; x++)
            {
                for (int y = y0 + 2; y < ym - 2; y++)
                {
                    if (Matrix[y - 1, x] == -1 && Matrix[y, x - 1] == -1) { Matrix[y - 1, x] = 1; Matrix[y, x - 1] = 1; }
                    if (Matrix[y + 1, x] == -1 && Matrix[y, x - 1] == -1) { Matrix[y + 1, x] = 1; Matrix[y, x - 1] = 1; }
                    if (Matrix[y - 1, x] == -1 && Matrix[y, x + 1] == -1) { Matrix[y - 1, x] = 1; Matrix[y, x + 1] = 1; }
                    if (Matrix[y + 1, x] == -1 && Matrix[y, x + 1] == -1) { Matrix[y + 1, x] = 1; Matrix[y, x + 1] = 1; }
                }
            }
        }
        private void DecorateWithPortals(List<int> portals)
        {
            Random rng = new Random();
            foreach (int portal in portals)
            {
                while (true)
                {
                    int x = rng.Next(2, Width - 2);
                    int y = rng.Next(2, Height - 2);
                    if (ValidPlace(x, y))
                    {
                        Matrix[y, x] = 2000 + portal;
                        break;
                    }
                }
            }
        }
        private void DecorateWithInteractions(List<Interaction> inters)
        {
            Interactions = new Dictionary<int, Interaction>();
            Random rng = new Random();
            foreach (Interaction inter in inters)
            {
                while (true)
                {
                    int x = rng.Next(2, Width - 2);
                    int y = rng.Next(2, Height - 2);
                    if (ValidPlace(x, y) && Matrix[y, x] == 1) 
                    {
                        if (Interactions.ContainsKey(Width * y + x)) continue;
                        Interactions.Add(Width * y + x, inter);
                        Matrix[y, x] = 3000 + Int32.Parse(inter.Name.Replace("interaction", ""));
                        break;
                    }
                }
            }
        }
        private void DecorateWithMonsters()
        {
            Random rng = new Random();
            for (int i = 0; i < monsters; i++)
            {
                int x = rng.Next(2, Width - 2); 
                int y = rng.Next(2, Height - 2);
                if (Matrix[y, x] != 1)
                {
                    i--;
                    continue;
                }
                Matrix[y, x] = 1000;
            }
        }

        // utility
        private bool ValidPlace(int x, int y)
        {
            if (x < 1 || y < 1 || x > Width - 2 || y > Height - 2) return false;
            if ((Matrix[y, x - 1] != 1 && Matrix[y, x + 1] != 1) && (Matrix[y - 1, x] == 1 && Matrix[y + 1, x] == 1)) return false;
            if ((Matrix[y - 1, x] != 1 && Matrix[y + 1, x] != 1) && (Matrix[y, x - 1] == 1 && Matrix[y, x + 1] == 1)) return false;
            return true;
        }

    }
}
