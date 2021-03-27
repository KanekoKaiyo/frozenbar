using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace hackaton
{
    enum MoveDisponible
    {
        up,
        down,
        left,
        right
    }
    static class Move
    {
        public static void MoveEntity(Entity entity,MoveDisponible md, Map map)
        {
            
            switch (md)
            {

                case MoveDisponible.up:
                    MoveEntity(entity, map, 0, -1);
                    break;
                case MoveDisponible.down:
                    MoveEntity(entity, map, 0, 1);
                    break;
                case MoveDisponible.left:
                    MoveEntity(entity, map, -1, 0);
                    break;
                case MoveDisponible.right:
                    MoveEntity(entity, map, 1, 0);
                    break;
            }
        }

        private static void MoveEntity(Entity entity, Map map, int x, int y)
        {
            
 
            int newx = entity.X + x;
            int newy = entity.Y + y;

            if (TestWall(map, newx, newy))
            {
                SetEntity(map, entity.X, entity.Y, newx, newy);
                entity.X = newx;
                entity.Y = newy;
            }

        }

        private static bool TestCrash(Map map,int x, int y)
        {
            if(map.MapGame[x][y] == null) return false;

            return true;
        }
        private static bool TestWall(Map map,int x, int y)
        {
            int[] mapLength = map.Lenght();
            if (0 <= x && x < mapLength[0] && 0 <= y && y < mapLength[1]) { 
                if(!(map.MapGame[x][y] != null && map.MapGame[x][y] is Wall)) return true;
            }

            return false;
        }

        private static void SetEntity(Map map, int x, int y, int newx, int newy)
        {
            map.SetInMap(map.Remove(x, y), newx, newy);
        }


    }
}
