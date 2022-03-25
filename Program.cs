using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MOD5_1302204079
{
    using System.Diagnostics.Contracts;

    public class SayaTubeVideo
    {
        protected int id;
        protected string title;
        protected int playCount;
        public SayaTubeVideo(string title)
        {
            Contract.Requires(title != null, "input null!");
            Contract.Requires(title.Length <= 100, "input melebihi batas");

            Random random = new();
            this.id = random.Next(99999);
            this.title = title;
            this.playCount = 0;
        }

        public void increasePlayCount(int number)
        {
            Contract.Requires(number <= 10000000, "input melebihi batas");
            try
            {
                checked
                {
                    this.playCount += number;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void printVideoDetails()
        {
            Console.WriteLine("ID\t\t:" + this.id.ToString());
            Console.WriteLine("Title\t\t:" + this.title);
            Console.WriteLine("Play Count\t:" + this.playCount.ToString());
        }
    }

    public class main
    {
        public static void Main()
        {
            SayaTubeVideo test = new(null);
            test.printVideoDetails();

            SayaTubeVideo baru = new("Cara mematikan windows defender" +
                " dan mematikan antivirus yang sedang aktif agar tidak mengganggu proses installasi");
            baru.printVideoDetails();

            SayaTubeVideo saya = new("Tutorial Design By Contract – Alwan Kemal.");
            saya.printVideoDetails();

            for (int i = 0; i < 4; i++)
            {
                saya.increasePlayCount(123456789);
            }
            saya.printVideoDetails();
        }
    }
}
