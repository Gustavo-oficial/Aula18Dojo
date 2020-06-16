using System;

namespace Aula18Dojo1
{
    public class Jogador
    {
        public string Nome { get; set; }
        public string Posicao { get; set; }
        public DateTime Nascimento { get; set; }
        public float Altura { get; set; }
        public float Peso {get; set;}
        public string Nacionalidade { get; set; }
        public int idade { get; set; }
        public string MostrarDados(){
            
            return $"Nome: {Nome}, Posição do jogador : {Posicao}, Altura : {Altura},Data de nascimento : {Nascimento}, Peso: {Peso}, Nacionalidade: {Nacionalidade}";
        }
        public int CalcularIdade(){
            int anoNasc = Int32.Parse(Nascimento.ToString().Split('/' ,' ')[2]);
            int anoAtual = Int32.Parse(DateTime.Now.ToString().Split('/' ,' ')[2]);

            idade = anoAtual - anoNasc;

            return idade;
            
        }
        public string CalcularAposentadoria(){
            string aposentadoria = "";

            if(Posicao == "Atacante" && idade >= 35){

                aposentadoria = "Você ja pode pedir sua aposentadoria!";

            }else if(Posicao == "Meio Campo" && idade >= 38){

                aposentadoria = "Você ja pode pedir sua aposentadoria!";

            }else if(Posicao == "Defesa" && idade >= 40){

                aposentadoria = "Você ja pode pedir sua aposentadoria!";

            }else if(Posicao == "Goleiro" && idade >= 42){

                aposentadoria = "Você ja pode pedir sua aposentadoria!";
            }else{
                aposentadoria = "Você ainda não pode se aposentar!Voce deve ter mais do que 35 anos";
            }

            return aposentadoria;

        }
    }
}