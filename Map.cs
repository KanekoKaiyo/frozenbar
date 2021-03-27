using System;
using System.Collections.Generic;
using System.Text;

namespace hackaton
{
    class Map
    {
        private int curs;

        private List<Entity[]> allMap;
        public Entity[][] MapGame { get; set; }
        public Map(int y)
        {

            //allMap = ASUPPRIMER();
            allMap = Loader.AddListEntity();
            MapGame = new Entity[allMap[0].Length][];
            
            for (int i = 0; i < MapGame.Length; i++)
            {
                MapGame[i] = new Entity[y];
            }

            for (int i = 0; i < MapGame[0].Length; i++)
            {
                for (int j = 0; j < MapGame.Length; j++)
                {
                    MapGame[j][i] = allMap[curs][j];
                }
                curs++;
                if (curs == allMap.Count) curs = 0;
            }
        }

        public int[] Lenght()
        {
            return new int[2]{MapGame.Length,MapGame[0].Length };
        }

        public Entity Remove(int x, int y)
        {
            Entity oldEntity = MapGame[x][y];
            MapGame[x][y] = null;
            return oldEntity;
        }

        public void SetInMap(Entity entity,int x, int y)
        {
            int[] mapLength = Lenght();
            if (0 <= x && x < mapLength[0] && 0 <= y && y < mapLength[1])
            {
                if (MapGame[x][y] != null && MapGame[x][y] is Wall) return;
                MapGame[x][y] = entity;
            }
        }


        public void Scroll()
        {
            List<Bullet> removeBullet = RemoveBullet();
            List<IControlable> removeShip = RemoveShip();

            Entity[][] newMapGame = new Entity[allMap[0].Length][];
            for (int i = 0; i < newMapGame.Length; i++)
            {
                newMapGame[i] = new Entity[MapGame[0].Length];
            }
            for (int i = 0; i < allMap[0].Length; i++)
            {
                for (int j = 0; j < MapGame[0].Length - 1; j++)
                {
                    newMapGame[i][j + 1] = MapGame[i][j];
                }
            }
            for (int i = 0; i < allMap[0].Length; i++)
            {
                newMapGame[i][0] = allMap[curs][i];
            }
            curs++;
            if (curs == allMap.Count) curs = 0;

            for (int i = 0; i < MapGame.Length; i++)
            {
                for (int j = 0; j < MapGame[0].Length; j++)
                {
                    if (newMapGame[i][j] != null) newMapGame[i][j].Y++;
                }
            }

            MapGame = newMapGame;


            Replacebullet(removeBullet);
            ReplaceShip(removeShip);
        }


        public void AddMonster()
        {
            Random rdn = new Random();

            for(int i = 0; i < MapGame.Length; i++)
            {
                if (rdn.NextDouble() <= 0.2) MapGame[i][0] = new Monster(i,0);
            }
        }

        private List<Bullet> RemoveBullet()
        {
            List<Bullet> lBullet = new List<Bullet> { };

            for (int i = 0; i < MapGame.Length; i++)
            {
                for (int j = 0; j < MapGame[0].Length; j++)
                {
                    if (MapGame[i][j] != null && MapGame[i][j] is Bullet) lBullet.Add(Remove(i,j) as Bullet);
                }
            }

            return lBullet;
        }

        private void Replacebullet(List<Bullet> l)
        {
            foreach(Bullet bul in l)
            {
                
                
                if (!(MapGame[bul.X][bul.Y] != null && MapGame[bul.X][bul.Y] is Wall))
                {
                    MapGame[bul.X][bul.Y] = null;
                }                
                if (!(MapGame[bul.X][bul.Y-1] != null && MapGame[bul.X][bul.Y-1] is Wall))
                {
                    MapGame[bul.X][bul.Y-1] = bul;
                    bul.Y--;
                }

                
            }
        }

        private List<IControlable> RemoveShip()
        {
            List<IControlable> lship = new List<IControlable> { };

            for (int i = 0; i < MapGame.Length; i++)
            {
                for (int j = 0; j < MapGame[0].Length; j++)
                {
                    if (MapGame[i][j] != null && MapGame[i][j] is IControlable) lship.Add(Remove(i, j) as IControlable);
                }
            }

            return lship;
        }

        private void ReplaceShip(List<IControlable> l)
        {
            foreach (Entity ship in l)
            {

                if (MapGame[ship.X][ship.Y] != null) continue;

                MapGame[ship.X][ship.Y] = ship;
            }
        }



        private List<Entity[]> ASUPPRIMER()
        {
            List<Entity[]> map = new List<Entity[]>(40);
            Entity[] case1 = new Entity[15];
            Entity[] case2 = new Entity[15];
            Entity[] case3 = new Entity[15];

            case1[0] = new Wall();
            case1[9] = new Wall();
            case2[0] = new Wall();
            case2[1] = new Wall();
            case2[14] = new Wall();
            case3[1] = new Wall();

            case3[2] = new Wall();
            case3[7] = new Wall();


            map.Add(case1);

            map.Add(case2);
            map.Add(case3);
                

            


            return map;
        }

        //public bool isOnMap()
        //{
        //    bool isOnMap = true;
        //    for(int i = 0; i <= MapGame.Length; i -=- i)
        //    {
        //        for (int j = 0; j <= MapGame[i].Length; i -= -i){
        //            if(MapGame[i][j] is IControlable)
        //            {

        //            } else
        //            {
        //                isOnMap = false;
        //                return isOnMap;
        //            }
        //        }
        //    }

        //    return isOnMap;
        //}


        public bool isOnMap()
        {
            for(int i = 0; i < MapGame.Length; i++)
            {
                for(int j =0; j < MapGame[0].Length; j++)
                {
                    if (MapGame[i][j] is IControlable) return true;
                }
            }
            return false;
        }
    }
}
