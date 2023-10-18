﻿using atividade;
using atividade.Models;
using atividade.Services;

FakeDatabase.InstituicaoEnsino = new InstituicaoEnsinoModel("SENAC");

bool rodar = true;
do
{
    try
    {
        rodar = Menu();
    }
    catch (Exception ex)
    {
        ConsoleExtension.Write(ex.Message, ConsoleColor.Red);
        throw;
    }
} while (rodar);


bool Menu()
{
    ConsoleExtension.Clear();
    ConsoleExtension.Write("0 - Sair");
    ConsoleExtension.Write("1 - Cadastrar Aluno");
    ConsoleExtension.Write("2 - Cadastrar Professor");
    ConsoleExtension.Write("3 - Ver Alunos");
    ConsoleExtension.Write("4 - Ver Professores");
    ConsoleExtension.Write("------------------------------------------");

    ConsoleExtension.Write("INSTITUIÇÃO DE ENSINO");
    ConsoleExtension.Write("5 - Adicionar Professor");
    ConsoleExtension.Write("6 - Remover Professor");
    var option = int.Parse(ConsoleExtension.Read());

    switch (option)
    {
        case 0:
            return false;
        case 1:
            FakeDatabase.Alunos.Add(AlunoService.Cadastrar(FakeDatabase.Alunos));
            break;
        case 2:
            FakeDatabase.Professores.Add(ProfessorService.Cadastrar());
            break;
        case 3:
            verAlunos();
            break;
        case 4:
            VerProfessores();
            break;
        case 5:
            InstituicaoEnsinoService.AdicionarProfessor(ConsoleExtension.WriteAndRead("Nome do professor a ser adicionado"));
            break;
        case 6:
            InstituicaoEnsinoService.AdicionarProfessor(ConsoleExtension.WriteAndRead("Nome do professor a ser removido"));
            break;
        default:
            ConsoleExtension.Write("opção inválida, tente novamente", ConsoleColor.Red);
            break;
    }
    return true;
}

void VerProfessores()
{
    ConsoleExtension.Clear();
    foreach (var p in FakeDatabase.Professores)
    {
        ConsoleExtension.Write(p.MostrarDados());
    }
}

void verAlunos()
{
    ConsoleExtension.Clear();
    foreach (var a in FakeDatabase.Alunos)
    {
        ConsoleExtension.Write(a.ToString());
    }
}