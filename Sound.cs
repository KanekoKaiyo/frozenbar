using System;
using System.Collections.Generic;
using System.Media;
using System.Text;

namespace hackaton {
    class Sound {
        SoundPlayer[] songs = new SoundPlayer[37];

        public Sound() {
            songs[0] = new SoundPlayer(Properties.Resources._0);
            songs[1] = new SoundPlayer(Properties.Resources._1);
            songs[2] = new SoundPlayer(Properties.Resources._2);
            songs[3] = new SoundPlayer(Properties.Resources._3);
            songs[4] = new SoundPlayer(Properties.Resources._4);
            songs[5] = new SoundPlayer(Properties.Resources._5);
            songs[6] = new SoundPlayer(Properties.Resources._6);
            songs[7] = new SoundPlayer(Properties.Resources._7);
            songs[8] = new SoundPlayer(Properties.Resources._8);
            songs[9] = new SoundPlayer(Properties.Resources._9);
            songs[10] = new SoundPlayer(Properties.Resources._10);
            songs[11] = new SoundPlayer(Properties.Resources._11);
            songs[12] = new SoundPlayer(Properties.Resources._12);
            songs[13] = new SoundPlayer(Properties.Resources._13);
            songs[14] = new SoundPlayer(Properties.Resources._14);
            songs[15] = new SoundPlayer(Properties.Resources._15);
            songs[16] = new SoundPlayer(Properties.Resources._16);
            songs[17] = new SoundPlayer(Properties.Resources._17);
            songs[18] = new SoundPlayer(Properties.Resources._18);
            songs[19] = new SoundPlayer(Properties.Resources._19);
            songs[20] = new SoundPlayer(Properties.Resources._20);
            songs[21] = new SoundPlayer(Properties.Resources._21);
            songs[22] = new SoundPlayer(Properties.Resources._22);
            songs[23] = new SoundPlayer(Properties.Resources._23);
            songs[24] = new SoundPlayer(Properties.Resources._24);
            songs[25] = new SoundPlayer(Properties.Resources._25);
            songs[26] = new SoundPlayer(Properties.Resources._26);
            songs[27] = new SoundPlayer(Properties.Resources._27);
            songs[28] = new SoundPlayer(Properties.Resources._28);
            songs[29] = new SoundPlayer(Properties.Resources._29);
            songs[30] = new SoundPlayer(Properties.Resources._30);
            songs[31] = new SoundPlayer(Properties.Resources._31);
            songs[32] = new SoundPlayer(Properties.Resources._32);
            songs[33] = new SoundPlayer(Properties.Resources._33);
            songs[34] = new SoundPlayer(Properties.Resources._34);
            songs[35] = new SoundPlayer(Properties.Resources._35);
            songs[36] = new SoundPlayer(Properties.Resources._36);
        }
        public SoundPlayer genRand() {
            SoundPlayer song;

            Random rand=new Random();
            int nbRand = rand.Next(0, 36);

            song = songs[nbRand];
            return song;
        }
    }
}
