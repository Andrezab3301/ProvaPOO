using System;
using System.Globalization;

namespace Course
{
    class veiculo
    {
        public int _posicaox;
        public int _posicaoy;
        public string _clasificacao;
        public string _situacao;
        public string _combustivel;
        public double _velocidade;

        public veiculo(int posicaoy, int posicaox, string clasificacao, string situacao, string combustivel, double velocidade){
            _posicaoy = posicaoy;
            _posicaox = posicaox;
            _clasificacao = clasificacao;
            _situacao = situacao;
            _combustivel = combustivel;
            _velocidade = velocidade;
        }
        public veiculo(int posicaoy, int posicaox, string clasificacao, string combustivel, double velocidade){
            _posicaoy = posicaoy;
            _posicaox = posicaox;
            _clasificacao = clasificacao;
            _situacao = "Circulando";
            _combustivel = combustivel;
            _velocidade = velocidade;
        }
        public void AdicionarClasificacao(string clasificacao){
            _clasificacao = clasificacao;
        }
         public void AdicionarSituacao(string situacao){
            _situacao = situacao;
        }
         public void AdicionarCombustivel(string combustivel){
            _combustivel = combustivel;
        }
         public void AdicionarVelocidade(double velocidade){
            _velocidade = velocidade;
        }
        public void AdicionarPosicaox(int posicaox){
            _posicaox = posicaox;
        }
        public void AdicionarPosicaoy(int posicaoy){
            _posicaoy = posicaoy;
        }

        public int RetornaPosicaoy(){
            return _posicaoy;
        }
        public int RetornaPosicaox(){
            return _posicaox;
        }
        public string RetornaClasificacao(){
            return _clasificacao;
        }
        public string RetornaSituacao(){
            return _situacao;
        }
        public string RetornaCombustivel(){
            return _combustivel;
        }
        public double RetornaVelocidade(){
            return _velocidade;
        }
    }
}