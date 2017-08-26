﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trash_Collector_Agent.src
{
    class Program
    {
        public const String path = @"D:\Desenvolvimento\Github\Trash_Collector_Agent\Trash_Collector_Agent\Trash_Collector_Agent\logs\logs.txt";

        public static void CreateFile()
        {
            try
            {
                // Delete the file if it exists.
                if (File.Exists(path))
                {
                    // Note that no lock is put on the
                    // file and the possibility exists
                    // that another process could do
                    // something with it between
                    // the calls to Exists and Delete.
                    File.Delete(path);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
        }

        public static void WriteToLog(String logInformation)
        {
            try
            {
                File.AppendAllText(path, logInformation);
                File.AppendAllText(path, System.Environment.NewLine);
                //using (FileStream fs = File.OpenWrite(path))
                //{
                //    //FileStream fs = File.AppendAllText(path, logInformation);
                    
                //    //Byte[] info = new UTF8Encoding(true).GetBytes(logInformation);
                //    // Add some information to the file.
                //    //fs.Write(info, 0, info.Length);
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
        }

        public static void breakLines()
        {
            Console.WriteLine(System.Environment.NewLine);
            Console.WriteLine(System.Environment.NewLine);
            Console.WriteLine(System.Environment.NewLine);
        }

        static void Main(string[] args)
        {

            #region TESTE DE ESCRITA DE LOG
            //Program.CreateFile();
            //Program.WriteToLog("Caspita.");
            #endregion

            #region DECLARAÇÃO DE VARIAVEIS
            Environment env;
            int size = 12;
            #endregion

            #region INICIALIZAÇÃO DO AMBIENTE
            env = new Environment(size);
            #endregion

            #region CHAMADA DE METODOS PARA INICIALIZAR MAPA E MOSTRAR AMBIENTE
            env.initializeMap();
            env.showEnvironment();
            env.buildWalls();

            Program.breakLines();
            
            env.showEnvironment();
            #endregion
            Console.ReadKey();


        }
    }
}
