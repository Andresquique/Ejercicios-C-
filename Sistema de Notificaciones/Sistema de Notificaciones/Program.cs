namespace Sistema_de_Notificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mail mail1 = new Mail();
            SMS sms1 = new SMS();

            mail1.Enviar();
            sms1.Enviar();
        }
    }
}
