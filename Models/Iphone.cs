namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero) : base(numero)
        {

        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Boolean status = true;
            Boolean statusMemoria = true;
            
            
            if(status) {
                ReceberLigacao();
            }
            else
            {
                status = false;
            }

            if (statusMemoria)
            {
                int memoria = 0;
                GravarDados(memoria);
            }
            else
            {
                statusMemoria = false;
            }
        }

        public void GravarDados(int memoria)
        {   
            if (memoria > 0) 
            {
                Console.WriteLine("Memoria Vazia");
            }
            else
            {
                Console.WriteLine("Memoria cheia");
            }
        }
        
        public void VerificaIMei()
        {

        }
    }
}