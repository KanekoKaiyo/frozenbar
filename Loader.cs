using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace hackaton
{
    static class Loader
    {
        private static int nbrline = 30, nbrchar = 15, i = 0, j = 0;
        private static Entity[][] map;

        private static string[][] RecupText()
        {
            string[][] result = new string[nbrline][];
            try
            {
                string input = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory +  "map.txt");

                foreach (var row in input.Split('\n'))
                {
                    j = 0;
                    result[i] = new string[nbrchar];
                    foreach (var col in row.Trim().Split(' '))
                    {
                        result[i][j] = col.Trim().ToString();
                        j++;
                    }
                    i++;
                }
               
            }catch(Exception e)
            {

            }

            return result;
        }
        private static Entity[][] Test()
        {
            string[][] tabTemp = RecupText();

            map = new Entity[nbrline][];

            try
            {
                for (i = 0; i < nbrline; i++)
                {
                    map[i] = new Entity[nbrchar];
                    for (j = 0; j < nbrchar; j++)
                    {
                        if (tabTemp[i][j] == "*")
                        {
                            map[i][j] = new Wall();
                        }
                        else
                        {
                            map[i][j] = null;
                        }
                    }
                }
            } catch(Exception e)
            {

            }
            
            return map;
        }
        public static List<Entity[]> AddListEntity()
        {
            Entity[][] tabTemp = Test();
            List<Entity[]> entities = new List<Entity[]>();

            for (i = 0; i < nbrline; i++)
            {

                entities.Add(tabTemp[i]);
                
            }
            return entities;
        }
    }
}