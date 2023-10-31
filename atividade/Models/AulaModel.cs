namespace atividade.Models;
public class AulaModel
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
}