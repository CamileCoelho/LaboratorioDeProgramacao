﻿using LaboratorioDeProgramacao.Dominio.ModuloDisciplina;

namespace LaboratorioDeProgramacao.Infra.Dados.Sql.ModuloDisciplina
{
    public class RepositorioDisciplinaJson : RepositorioBaseArquivo<Disciplina>, IRepositorioDisciplina
    {
        public RepositorioDisciplinaJson(ContextoDeDados contexto) : base(contexto)
        {
            
        }

        protected override List<Disciplina> ObterRegistros()
        {
            return contextoDeDados.disciplinas;
        }
    }
}