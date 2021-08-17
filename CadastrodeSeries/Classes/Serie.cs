using System;


namespace CadastrodeSeries
{
    //Classe 'Serie' herdando da classe 'EntidadeBase'
    public class Serie : EntidadeBase
    {
        //Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }


        //Construtor recebendo os dados classe 'Serie'
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }
        //Construtor vazio da classe 'Serie'
        public Serie() { }


        // Metodo de organiza��o dos dados da classe 'Serie'
        // Quando usarmos 'Console.WriteLine(Serie)', ser� mostrada a formata��o abaixo
        // 'Environment.NewLine' adiciona uma nova linha.
        public override string ToString()
        {
            string retorno = "";
            retorno += "G�nero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descricao: " + this.Descricao + Environment.NewLine;
            retorno += "Ano: " + this.Ano + Environment.NewLine;
            retorno += "Exclu�do: " + this.Excluido + Environment.NewLine;
            return retorno;
        }

        public string getTitulo()
        {
            return this.Titulo;
        }

        public int getId()
        {
            return this.Id;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }    
}