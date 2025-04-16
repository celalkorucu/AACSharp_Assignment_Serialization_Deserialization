using AACSharp_Assignment_Serialization_Deserialization.Classes;

namespace AACSharp_Assignment_Serialization_Deserialization
{
    internal static class Program
    {


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            //  Reflection : Reflection bir s�n�ftaki �zellikleri metodlar� ve bu gibi de�erleri bize g�steren yap�d�r
            //  Kullan�m amac� : Do�rudan eri�ilemeyen bir entitynin �zelliklerini de�i�tirmek
            //  Yazm�� oldu�um Product class�n�n �zellikleri : 

            var productClass = new Product();
            var productClassType = productClass.GetType();

            var properties = productClassType.GetProperties();

            foreach (var property in properties)
            {
                Console.WriteLine(property.Name);
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());



 
        }
    }
}