using CadastroDeCliente.Models;

namespace CadastroDeCliente.Data
{
    public class AppDBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppCont>();
                context.Database.EnsureCreated();

                // Criar os Clientes
                if (!context.Tarefas.Any())
                {
                    context.Tarefas.AddRange(new List<Cadastro_Cliente>()
                    {
                        new Cadastro_Cliente()
                        {
                            Nome = "João Pereira",
                            Email = "joao.pereira@gmail.com",
                            DataNascimento = new DateTime(1985, 3, 15),
                            Sexo = "M",
                            Logradouro = "Rua das Palmeiras",
                            Numero = 123,
                            Complemento = "Apto 101",
                            Bairro = "Centro",
                            Cidade = "São Paulo",
                            Estado = "SP",
                            CEP = "01001-000",
                            Foto = "path/to/foto1.jpg"
                        },
                        new Cadastro_Cliente()
                        {
                            Nome = "Maria Clara",
                            Email = "maria.clara@yahoo.com",
                            DataNascimento = new DateTime(1992, 7, 22),
                            Sexo = "F",
                            Logradouro = "Avenida das Rosas",
                            Numero = 456,
                            Complemento = "Bloco B, Apto 204",
                            Bairro = "Jardins",
                            Cidade = "Rio de Janeiro",
                            Estado = "RJ",
                            CEP = "20010-000",
                            Foto = "path/to/foto2.jpg"
                        },
                        new Cadastro_Cliente()
                        {
                            Nome = "Carlos Eduardo",
                            Email = "carlos.eduardo@hotmail.com",
                            DataNascimento = new DateTime(1978, 11, 5),
                            Sexo = "M",
                            Logradouro = "Travessa da Harmonia",
                            Numero = 789,
                            Complemento = "Sala 305",
                            Bairro = "Nova Esperança",
                            Cidade = "Belo Horizonte",
                            Estado = "MG",
                            CEP = "30120-000",
                            Foto = "path/to/foto3.jpg"
                        },
                        new Cadastro_Cliente()
                        {
                            Nome = "Ana Luiza",
                            Email = "ana.luiza@outlook.com",
                            DataNascimento = new DateTime(2000, 5, 30),
                            Sexo = "F",
                            Logradouro = "Alameda dos Ipês",
                            Numero = 101,
                            Complemento = "Casa 12",
                            Bairro = "Jardim Primavera",
                            Cidade = "Curitiba",
                            Estado = "PR",
                            CEP = "80045-000",
                            Foto = "path/to/foto4.jpg"
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
