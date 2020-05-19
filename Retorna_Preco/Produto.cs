using System.Globalization;

namespace Retorna_Preco
{
    class Produto
    {
        public int Id { get; set; }
        public int Qtd { get; set; }
        private double _vlTotal;
        private double _vlSubTotal;


        //CONSTRUTORES
        public Produto ()
        {

        }
        public Produto (int id, int qtd)
        {
            Id = id;
            Qtd = qtd;            
        }
        //METODOS
        public double CalculaValor(int id, int qtd)
        {
            //Soma total com o calculo do valor do produto
            _vlTotal = _vlTotal + ValorProdutos(id, qtd); 
            return _vlTotal;
        }

        public double ValorProdutos(int id, int qtd)
        {
            //-------------------------------------
            //METODO PARA CALCULAR VALOR DO PRODUTO
            //-------------------------------------
           
            switch (id)
            {
                case 1:
                    //Rosa Monique
                    double _rosaMonique = 0.1;
                    _vlSubTotal = _vlSubTotal + (_rosaMonique * qtd);
                    break;
                case 2:
                    //Sepala Pequena
                    double _sepalaPequena = 0.05;
                    _vlSubTotal = _vlSubTotal + (_sepalaPequena * qtd);
                    break;
                case 3:
                    //Folha Rosa Grande
                    double _folhaRosaGrande = 0.1;
                    _vlSubTotal = _vlSubTotal + (_folhaRosaGrande * qtd);
                    break;
                case 4:
                    //Folha Desidratada
                    double _folhaDesidratada = 0.05;
                    _vlSubTotal = _vlSubTotal + (_folhaDesidratada * qtd);
                    break;
                case 5:
                    //Arame
                    double _arame = 1.00;
                    _vlSubTotal = _vlSubTotal + (_arame * qtd);
                    break;
                case 6:
                    //Vaso Vidro
                    double _vasoVidro = 8.00;
                    _vlSubTotal = _vlSubTotal + (_vasoVidro * qtd);
                    break;
                case 7:
                    //Fita Floral
                    double _fitaFloral = 0.20;
                    _vlSubTotal = _vlSubTotal + (_fitaFloral * qtd);
                    break;
                default:
                    _vlSubTotal = _vlSubTotal + 0;
                    break;
            }
            return _vlSubTotal;
        }
        //Sobreposição        
        public override string ToString()
        {
            return "SubTotal: "
                 + _vlTotal.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
