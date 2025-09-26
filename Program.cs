using dio_dotnet_poo.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Marcos";
p1.Sobrenome = "Marques";
p1.Idade = 37;

Pessoa p2 = new Pessoa();
p2.Nome = "Leonardo";
p2.Sobrenome = "Buta";
p2.Idade = 30;

Pessoa p3 = new Pessoa();
p3.Nome = "Eduardo";
p3.Sobrenome = "Neves";
p3.Idade = 22;

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.ListarAlunos();