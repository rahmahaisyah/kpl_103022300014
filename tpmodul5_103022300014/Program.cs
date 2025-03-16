namespace tpmodul5_103022300014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric halo = new HaloGeneric();
            halo.SapaUser("Rahmah");

            DataGeneric<string> dataNIM = new DataGeneric<string>("103022300014");
            dataNIM.PrintData();
        }
    }
}
