using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ClientWcfService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class Service1 : IService1
    {
        // Contém métodos responsáveis por interagir com a base de dados.
        public Cliente GetData(int value)
        {
            // Não conectamos a uma base de dados então retornamos um objeto, para isso instanciamos a classe Cliente
            var cliente = new Cliente { Id = 1, Name = "Gustavo", CPF = "44295616822" };
            return cliente;
        }

        public List<Cliente> All()
        {
            var clientes = new List<Cliente>();
            clientes.Add(new Cliente { Id = 1, Name = "Gustavo", CPF = "442956168" });
            clientes.Add(new Cliente { Id = 2, Name = "Maria", CPF = "554878564" });
            clientes.Add(new Cliente { Id = 3, Name = "Joao", CPF = "356547874" });
            return clientes;
        }

        public bool Save(string name, string cpf)
        {
            try
            {
                bool saved = new Cliente() { Name = name, CPF = cpf }.Save();
                return saved;
            }
            catch { return false; }            
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
