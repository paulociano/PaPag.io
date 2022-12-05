using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using papagio.Models;

namespace papagio.Dados
{
    public class DBInitializer
    {
        public static void Initialize(Context context)
        {
            if (context.Database.EnsureCreated())
            {
                //Criar usuário admin
                context.Usuarios.Add(
                    new Usuario
                    {
                        Nome = "Administrador",
                        Login = "admin",
                        Senha = "123"
                    });

                //Categorias
                var telefonia = new CategoriaDespesa{Descricao = "Telefonia"};
                var moradia = new CategoriaDespesa{Descricao = "Moradia"};
                var lazer = new CategoriaDespesa{Descricao = "Lazer"};
                var educacao = new CategoriaDespesa { Descricao = "Educação" };
                var transporte = new CategoriaDespesa { Descricao = "Transporte" };
                var investimento = new CategoriaDespesa { Descricao = "Investimento" };
                var alimentação = new CategoriaDespesa { Descricao = "Alimentação" };
                var outros = new CategoriaDespesa { Descricao = "Outros" };
                context.CategoriaDespesas.Add(telefonia);
                context.CategoriaDespesas.Add(moradia);
                context.CategoriaDespesas.Add(lazer);
                context.CategoriaDespesas.Add(educacao);
                context.CategoriaDespesas.Add(transporte);
                context.CategoriaDespesas.Add(investimento);
                context.CategoriaDespesas.Add(alimentação);
                context.CategoriaDespesas.Add(outros);

                //Despesas
                var d1 = new Despesa { Descricao = "Plano Celular", CategoriaDespesaId = 1 };
                var d2 = new Despesa { Descricao = "Aluguel Apartamento", CategoriaDespesaId = 2 };
                var d3 = new Despesa { Descricao = "Mensalidade Clube", CategoriaDespesaId = 3 };
                var d4 = new Despesa { Descricao = "Livros Acadêmicos", CategoriaDespesaId = 4 };
                var d5 = new Despesa { Descricao = "Uber", CategoriaDespesaId = 5 };
                var d6 = new Despesa { Descricao = "Compra de Ações", CategoriaDespesaId = 6 };
                var d7 = new Despesa { Descricao = "Supermercado", CategoriaDespesaId = 7 };
                var d8 = new Despesa { Descricao = "Viagem Férias", CategoriaDespesaId = 8 };

                context.SaveChanges();
            }
        }
    }
}
