using System;

using System.Threading;
using FDTGloveUltraCSharpWrapper;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.IO;

namespace Rukavichka
{
    class Client
    {

        public Client(TcpClient Client)
        {
            CfdGlove fdGlove; //Glove class
            float[] farr = new float[20];

            fdGlove = new CfdGlove(); //create a new glove
            fdGlove.Open("USB0");
            fdGlove.SetCalibration(0, 4000, 3000);

            // reading
            for (int j = 0; j < 50; )
            {
                fdGlove.GetSensorScaledAll(ref farr); //read values

                string data = "[";
               

                for (int i = 0; i < 18; ++i)
                {
                    Console.WriteLine("Sensor " + i + " - Scaled: " + String.Format("{0:0.00}", farr[i]));
                    string number =  farr[i].ToString();

                    data += String.Format("{0:0}", farr[i]);

                    if (i != 17)
                    {
                        data += ",";
                    }
                }

                data += "]";
                byte[] Buffer = Encoding.ASCII.GetBytes(data);
                
                Client.GetStream().Write(Buffer, 0, Buffer.Length);
                Thread.Sleep(2000);
                Console.Clear();
            }
            // end reading


            fdGlove.Close(); //close the glove
        }
    }

    class Server
    {
        TcpListener Listener; // Объект, принимающий TCP-клиентов

        // Запуск сервера
        public Server(int Port)
        {
            // Создаем "слушателя" для указанного порта
            Listener = new TcpListener(IPAddress.Any, Port);
            Listener.Start(); // Запускаем его

            // В бесконечном цикле
            while (true)
            {
                // Принимаем новых клиентов
                new Client(Listener.AcceptTcpClient());
            }
        }

        // Остановка сервера
        ~Server()
        {
            // Если "слушатель" был создан
            if (Listener != null)
            {
                // Остановим его
                Listener.Stop();
            }
        }
    }

   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kek");
            new Server(80);
            /*
            CfdGlove fdGlove; //Glove class
            float[] farr = new float[20];

            fdGlove = new CfdGlove(); //create a new glove
            fdGlove.Open("USB0");
            fdGlove.SetCalibration(0, 4000, 3000);

            // reading
            for (int j = 0; j < 50; j++)
            {
                fdGlove.GetSensorScaledAll(ref farr); //read values

                for (int i = 0; i < 18; ++i)
                {
                    Console.WriteLine("Sensor " + i + " - Scaled: " + String.Format("{0:0.00}", farr[i]));
                }

                Thread.Sleep(500);
                Console.Clear();
            }
            // end reading
               

            fdGlove.Close(); //close the glove
            */
            Console.ReadKey(true);
        }
    }
}
