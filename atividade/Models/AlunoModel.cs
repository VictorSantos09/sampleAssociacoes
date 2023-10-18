﻿namespace atividade.Models;
internal class AlunoModel
{
    public string Nome { get; set; }
    public string Sexo { get; set; }
    public AlunoModel AlunoDupla { get; set; }

    public AlunoModel(string nome, string sexo)
    {
        Nome = nome;
        Sexo = sexo;
    }

    public override string? ToString()
    {
        return $"Meu nome é '{Nome}' tenho o sexo '{Sexo}' e minha dupla é '{AlunoDupla.Nome}' do sexo '{AlunoDupla.Sexo}'";
    }

    public void FormarDupla(AlunoModel aluno)
    {
        AlunoDupla = aluno;
    }

    public string NomeDupla()
    {
        return $"Dupla: {Nome} - {AlunoDupla.Nome}";
    }
}
