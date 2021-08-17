using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrodeSeries.Interfaces
{
    //T é uma variável genérica
    public interface IRepositorio<T>
    {
        //Método lista que retorna uma lista de T
        List<T> Lista();
        T retornaPorID(int id);
        void Inserir(T entidade);
        void Excluir(int id);
        void Atualizar(int id, T entidade);
        int ProximoId();
    }
}
