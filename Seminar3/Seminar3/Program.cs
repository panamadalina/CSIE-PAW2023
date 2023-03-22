namespace Seminar3 {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // // To customize application configuration such as set high DPI settings or default font,
            // // see https://aka.ms/applicationconfiguration.
            // // ApplicationConfiguration.Initialize();
            // // Application.Run(new Form1());
            // int[] v = { 0, 2, 4, 6, 8 };
            // //for (int i=0;i<v.Length;i++) {
            // //    Console.Write(v[i]+",");
            // //}
            // afisare(v);
            // //Console.WriteLine("\nNumele dumnv: ");
            //// string nume= Console.ReadLine();

            // //Console.WriteLine("Hello, "+nume);
            // Console.WriteLine("\n---\n ");

            // int[] v2 = (int[])v.Clone();
            // Console.WriteLine("\n-V2:--\n ");
            // afisare(v2);
            // v[0] = 3;
            // Console.WriteLine("\n-V modif--\n ");
            // afisare(v);
            // Console.WriteLine("\n-V2 ?--\n ");
            // afisare(v2);

            /*  Animal a1 = new Animal();
              Animal a2 = new Animal("Leu", 10, 20);
              // Animal a3 = a2.Clone();//new Animal(a2);//a2
              Animal a3 = (Animal)a2.Clone();//new Animal(a2);//a2;//!!!!!!!

              Console.WriteLine(a1.ToString());
              Console.WriteLine(a2.ToString());
              Console.WriteLine(a3.ToString());
              Console.WriteLine();
              a2.Varsta = 50;

              Console.WriteLine(a2.ToString());
              Console.WriteLine(a3.ToString());

              */
            int[] note = { 0, 2, 4, 6, 8 };
            Student s1 = new Student(24, "Mada", note);
            //Console.WriteLine(s.spuneAnNastere());
            int[] note2 = { 0, 2, 4, 6, 8 };
            Student s2 = new Student(24, "Mada", note);
            Console.WriteLine(s1.CompareTo(s2));
          //  Console.WriteLine(s.spuneAnNastere());
        }

        public static void afisare(int[] v) {
            for (int i = 0; i < v.Length; i++) {
                Console.Write(v[i] + ",");
            }
        }

    }
}