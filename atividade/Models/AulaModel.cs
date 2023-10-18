namespace atividade.Models;
internal class AulaModel
{
    public SalaModel Sala { get; set; }
    public TurmaModel Turma { get; set; }
    public ProfessorModel Professor { get; set; }

    public AulaModel(SalaModel sala, TurmaModel turma, ProfessorModel professor)
    {
        Sala = sala;
        Turma = turma;
        Professor = professor;
    }

    public override string ToString()
    {
        return $"Sala: {Sala.Nome} - Turma: {Turma.Nome} - Período: {Turma.Periodo} - Professor: {Professor.Nome}";
    }
}